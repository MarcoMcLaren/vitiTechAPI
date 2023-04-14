using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class EventPrice
    {
        [Key]
        public int EventPriceID { get; set; }

        [ForeignKey("EventID")]
        public int EventID { get; set; }
        public Event Event { get; set; }

        public double Amount { get; set; }
    }
}
