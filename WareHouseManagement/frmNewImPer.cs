using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseLib;
using WareHouseManagement.Models;

namespace WareHouseManagement
{
    public partial class frmNewImPer : Form
    {
        private readonly Products prodsDb;
        private readonly Providers provDb;
        private readonly Warehouses wareDb;
        private readonly SupplyPermissions spDb;
        private List<Product> Products;
        private SupplyPermissionsProductsDB sppDB;
        private readonly WareHouseProdsDB whpDB;
        private readonly MeasureUnitsDB muDB;
        public frmNewImPer()
        {
            InitializeComponent();
            prodsDb = new Products();
            provDb = new Providers();
            wareDb = new Warehouses();
            Products = new List<Product>();
            spDb = new SupplyPermissions();
            sppDB = new SupplyPermissionsProductsDB();
            whpDB = new WareHouseProdsDB();
            muDB = new MeasureUnitsDB();
        }

        private async void AddCustomSuggestion()
        {
            var prodsNames = await prodsDb.GetProducts();
            AutoCompleteStringCollection cs = new AutoCompleteStringCollection();
            foreach(var prodname in prodsNames)
            {
                cs.Add(prodname.Name);
            }
            txtName.AutoCompleteCustomSource = cs;
        }

        private async void frmNewImPer_Load(object sender, EventArgs e)
        {
            // loading necessary data
            AddCustomSuggestion();
            // loading all providers
            this.Text = "اذن توريد جديد - تحميل...";
            cmbProvider.DataSource =  await provDb.GetProviders();
            cmbProvider.ValueMember = "Id";
            cmbProvider.DisplayMember = "Name";

            // loading all warehouses            
            cmbWareHouse.DataSource = await wareDb.GetWarehouses();
            cmbWareHouse.ValueMember = "Id";
            cmbWareHouse.DisplayMember = "Name";            

            this.Text = "اذن توريد جديد";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dtProds.SelectedRows.Count == 1)
            {
                deleteSelectedMenuItem.Enabled = true;
                editSelectedMenuItem.Enabled = true;
            }
            else
            {
                deleteSelectedMenuItem.Enabled = false;
                editSelectedMenuItem.Enabled = false;
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {            
            if (Validation.IsNotEmpty(txtName.Text, txtMeasureUnit.Text) && (dtProduction.Text != dtExpiration.Text || dtExpiration.Value > dtProduction.Value) && nmQuantity.Value > 0)
            {                
                // only adding the products data to the view
                dtProds.Rows.Add(txtName.Text, txtMeasureUnit.Text, dtProduction.Value, dtExpiration.Value, cmbProvider.SelectedValue, nmQuantity.Value);
                Product product = new Product
                {
                    Name = txtName.Text,
                    MeasureUnit = txtMeasureUnit.Text,
                    ProductionDate = dtProduction.Value,
                    ExpirationDate = dtExpiration.Value,
                    ProviderId = Convert.ToInt32(cmbProvider.SelectedValue.ToString()),
                };
                Products.Add(product);
                Utility.EmptyFields(txtMeasureUnit, txtName);
                nmQuantity.Value = 0;
            }
            else
            {
                MessageBox.Show("مدخلات غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private async void btnNewPer_Click(object sender, EventArgs e)
        {
            if(dtProds.Rows.Count > 0)
            {
                List<Product> temp = new List<Product>();
                // adding when adding the permission itself
                btnNewPer.Enabled = false;
                btnNewPer.Text = "يتم الاضافة الان...";
                //Products.Clear();
                foreach(var product in Products)
                {                    
                    temp.Add(await prodsDb.CreateOrNo(product, Convert.ToInt32(cmbWareHouse.SelectedValue.ToString())));
                }                

                // adding new supply permission
                SupplyPermission sp = new SupplyPermission
                {
                    PermissionDate = DateTime.Now,
                    WareHouseId = Convert.ToInt32(cmbWareHouse.SelectedValue.ToString())
                };
                await spDb.Create(sp);

                //Products = await prodsDb.GetProductsWithCount(dtProds.Rows.Count);
                
                int counter = 0;
                foreach (var product in temp)
                {
                    await whpDB.UpdateOrCreate(new WareHouseProducts
                    {
                        ProductId = product.Id,
                        WareHouseId = Convert.ToInt32(cmbWareHouse.SelectedValue.ToString()),
                        Quantity = Convert.ToInt32(dtProds.Rows[counter].Cells[5].Value.ToString())
                    });

                    // saving supply persmissions along with products in the database
                    SupplyPermissionProducts sproducts = new SupplyPermissionProducts
                    {
                        SupplyPerId = sp.Id,
                        ProductId = product.Id,
                        Quantity = Convert.ToInt32(dtProds.Rows[counter].Cells[5].Value.ToString())
                    };
                    await sppDB.Create(sproducts);
                    counter++;
                }
                
                btnNewPer.Text = "اضافة اذن جديد";
                btnNewPer.Enabled = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("مدخلات غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
    }
}
