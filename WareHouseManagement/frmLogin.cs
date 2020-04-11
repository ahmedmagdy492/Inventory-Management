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
    public partial class frmLogin : Form
    {
        private Users usersDB;
        public frmLogin()
        {
            InitializeComponent();
            usersDB = new Users();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // setting the password char
            txtPasswd.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // checking for validation
            if(Validation.IsNotEmpty(txtUsername.Text, txtPasswd.Text))
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "تحميل...";
                // if input data is valid
                var logingUser = await usersDB.Login(txtUsername.Text, txtPasswd.Text);
                btnLogin.Enabled = true;
                btnLogin.Text = "تسجيل دخول";
                if (logingUser == null)
                {
                    MessageBox.Show("كلمه المرور او اسم المستخدم غير صحيح","خطأ", MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign|MessageBoxOptions.RtlReading);
                }
                else
                {
                    // moving to the next form
                    this.Hide();
                    MainPanel mainPanel = new MainPanel();
                    mainPanel.Show();
                }
            }
            else
            {
                MessageBox.Show("برجاء ادخال كلمه المرور و اسم المستخدم","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void txtPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
