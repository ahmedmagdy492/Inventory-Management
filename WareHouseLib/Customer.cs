using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseLib
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public bool IsDeleted { get; set; }
        public List<DismissalPermission> DismissalPermission { get; set; }
    }
}
