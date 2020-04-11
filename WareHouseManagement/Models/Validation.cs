using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WareHouseManagement.Models
{
    static class Validation
    {
        public static bool IsNotEmpty(params string[] fields)
        {
            bool isValid = true;
            foreach(string field in fields)
            {
                if(string.IsNullOrWhiteSpace(field))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static bool IsValidUserName(string username)
        {
            Regex regex = new Regex("^[a-zA-Z]{5,15}[0-9]?$");
            bool isValid = true;
            if(!regex.IsMatch(username))
            {
                isValid = false;
            }
            return isValid;
        }

        public static bool IsValidPasswd(string passwd)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]{5,15}$");
            bool isValid = true;
            if (!regex.IsMatch(passwd))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
