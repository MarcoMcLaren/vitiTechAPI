using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        public int Stock_Limit { get; set; }

        public int Quantity_On_Hand { get; set; }

        [ForeignKey("WineID")]
        public int? WineID { get; set; }
        public Wine Wine { get; set; }

        public List<StockTake_Item> StockTake_Items { get; set; }

    }
}
