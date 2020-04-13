using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{
    public class WareHouseProducts
    {
        [Key]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [Key]
        [ForeignKey("Warehouse")]
        [Column(Order = 2)]
        public int WareHouseId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}