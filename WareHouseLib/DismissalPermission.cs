using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class DismissalPermission
    {
        [Key]
        public int Id { get; set; }
        public DateTime PermissionDate { get; set; }                
        [ForeignKey(nameof(Warehouse))]
        public int WareHouseId { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public bool IsDeleted { get; set; }
        public List<DismissalPermissionProducts> DismissalPermissionProducts { get; set; }
        public Warehouse Warehouse { get; set; }
        public Customer Customer { get; set; }
    }
}