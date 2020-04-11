using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class SupplyPermission
    {
        [Key]
        public int Id { get; set; }        
        public DateTime PermissionDate { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(nameof(Warehouse))]
        public int WareHouseId { get; set; }
        public bool IsDeleted { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}