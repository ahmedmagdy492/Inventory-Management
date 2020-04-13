using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class DismissalPermissionProducts
    {
        [Key]
        [ForeignKey(nameof(Product))]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [Key]
        [ForeignKey(nameof(DismissalPermission))]
        [Column(Order = 2)]
        public int DismissalPerId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public DismissalPermission DismissalPermission { get; set; }
    }
}