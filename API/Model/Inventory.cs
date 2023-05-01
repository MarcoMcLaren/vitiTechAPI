using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        public int StockLimit { get; set; }

        public int QuantityOnHand { get; set; }

        [ForeignKey("WineID")]
        public int? WineID { get; set; }
        public Wine Wine { get; set; }

        public List<StockTake_Item> StockTake_Items { get; set; }

    }
}
