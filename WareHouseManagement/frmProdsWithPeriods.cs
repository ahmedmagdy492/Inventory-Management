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

    public enum DateType
    {
        ProductionDate = 1,
        ExpirationDate = 2
    }
    public partial class frmProdsWithPeriods : Form
    {
        private WareHouseProdsDB prodDB;
        public frmProdsWithPeriods()
        {
            InitializeComponent();
            prodDB = new WareHouseProdsDB();
        }

        private void AddToView(List<WareHouseProducts> prods)
        {
            dtProds.Rows.Clear();
            foreach(var prod in prods)
            {
                dtProds.Rows.Add(prod.Product.Name, prod.Quantity, prod.Product.ProductionDate, prod.Product.ExpirationDate);
            }
        }

        private double DateTimeConverter(DateTime date, DateType dtType)
        {
            TimeSpan passedTime;
            if (dtType == DateType.ProductionDate)
            {
                passedTime = DateTime.Now - date;
            }
            else
            {
                passedTime = date - DateTime.Now;
            }
            return passedTime.TotalDays / 30;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // getting all data
            List<WareHouseProducts> allProds =  await prodDB.GetAllIncludeProduct();
            List<WareHouseProducts> prods = new List<WareHouseProducts>();
            foreach(var prod in allProds)
            {
                int months = 0;
                if (cmbtype.SelectedValue.ToString() == "تاريخ انتاج")
                {
                    months = (int)DateTimeConverter(prod.Product.ProductionDate, DateType.ProductionDate);
                }
                else
                {
                    months = (int)DateTimeConverter(prod.Product.ExpirationDate, DateType.ExpirationDate);
                }
                if(months >= nmPeriod.Value && months <= nmTo.Value)
                {
                    prods.Add(prod);
                }
            }
            AddToView(prods);
        }

        private void frmProdsWithPeriods_Load(object sender, EventArgs e)
        {                        
            List<string> items = new List<string>();
            items.Add("تاريخ انتاج");
            items.Add("تاريخ صلاحية");
            cmbtype.DataSource = items;
        }
    }
}
