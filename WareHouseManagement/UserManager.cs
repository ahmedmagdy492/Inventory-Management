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
    public partial class UserManager : Form
    {
        private Users usersDb;
        private List<User> Users;
        public UserManager()
        {
            InitializeComponent();
            usersDb = new Users();
        }

        private async void UserManager_Load(object sender, EventArgs e)
        {
            // loading available users
            this.Users = await usersDb.GetUsers();
            dtUsers.DataSource = this.Users;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtUsername.Text, txtPasswd.Text, txtConfirmPass.Text))
            {
                if(txtPasswd.Text == txtConfirmPass.Text)
                {
                    if (Validation.IsValidUserName(txtUsername.Text) && Validation.IsValidPasswd(txtPasswd.Text))
                    {
                        btnSave.Enabled = false;
                        btnSave.Text = "يتم الحفظ...";
                        // creating a new user
                        dtUsers.DataSource = await usersDb.CreateUser(txtUsername.Text, txtPasswd.Text);
                        btnSave.Enabled = true;
                        btnSave.Text = "حفظ";
                        Utility.EmptyFields(txtUsername, txtPasswd, txtConfirmPass);
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمه المرور غير صالحين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                }
                else
                {
                    MessageBox.Show("تاكيد كلمه المرور غير مطابفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dtUsers.SelectedRows.Count == 1)
            {
                deleteSelectedMenuItem.Enabled = true;
            }
            else
            {
                deleteSelectedMenuItem.Enabled = false;
            }
        }

        private async void deleteSelectedMenuItem_Click(object sender, EventArgs e)
        {
            // deleting a user
            lblStatus.Text = "تحميل....";
            int id = Convert.ToInt32(dtUsers.SelectedRows[0].Cells[0].Value.ToString());
            var user = await usersDb.GetUser(id);            
            dtUsers.DataSource =  await usersDb.DeleteUser(user);
            lblStatus.Text = "تم";
        }
    }
}
