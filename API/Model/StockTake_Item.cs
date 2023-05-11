using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class StockTake_Item
    {
        [Key]
        public int StockTake_ItemID { get; set; }

        [ForeignKey("StockTakeID")]
        [Required]
        public int StockTakeID { get; set; }
        public StockTake StockTake { get; set; }

        [ForeignKey("InventoryID")]
        public int InventoryID { get; set; }
        public Inventory Inventory { get; set; }

        public int QuantityCounted { get; set; }
    }
}
