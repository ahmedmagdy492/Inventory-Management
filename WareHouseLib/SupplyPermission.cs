using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class SupplyPermission
    {
        [Key]
        public int Id { get; set; }        
        public DateTime PermissionDate { get; set; }        
        public List<SupplyPermissionProducts> SupplyPermissionProducts { get; set; }

        [ForeignKey(nameof(Warehouse))]
        public int WareHouseId { get; set; }
        public bool IsDeleted { get; set; }        
        public Warehouse Warehouse { get; set; }
    }
}