using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class SupplyPermissionProducts
    {
        [Key]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [Key]
        [ForeignKey("SupplyPermission")]
        [Column(Order = 2)]
        public int SupplyPerId { get; set; }
        public int Quantity { get; set; }    
        public Product Product { get; set; }
        public SupplyPermission SupplyPermission { get; set; }
    }
}