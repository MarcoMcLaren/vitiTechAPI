using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class StockTake
    {
        [Key]
        public int StockTakeID { get; set; }

        public DateTime StockTake_Date { get; set; }

        [MaxLength(255)]
        public string StockTake_Notes { get; set; }

        public ICollection<StockTake_Item> StockTake_Items { get; set; }
    }
}
