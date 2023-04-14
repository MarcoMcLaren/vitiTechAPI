using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WineDiscount
    {
        [Key]
        public int WineDiscountID { get; set; }

        [ForeignKey("WineID")]
        public int WineID { get; set; }
        public Wine Wine { get; set; }

        [ForeignKey("DiscountID")]
        public int DiscountID { get; set; }
        public Discount Discount { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
