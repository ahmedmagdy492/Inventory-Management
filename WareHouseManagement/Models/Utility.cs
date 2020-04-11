using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseManagement.Models
{
    static class Utility
    {
        public static void EmptyFields(params Control[] feilds)
        {
            foreach(var control in feilds)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
        }
    }
}
