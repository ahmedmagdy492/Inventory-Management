using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseLib
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string StoreKeeper { get; set; }
        public bool IsDeleted { get; set; }
        public List<SupplyPermission> SupplyPermission { get; set; }
        public List<WareHouseProducts> WarehouseProducts { get; set; }
    }
}
