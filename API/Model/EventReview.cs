using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class EventReview
    {
        [Key]
        public int EventReviewID { get; set; }

        [ForeignKey("EventID")]
        public int EventID { get; set; }
        public Event Event { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int Rating { get; set; }

        [MaxLength(255)]
        public string Comment { get; set; }

        public DateTime Review_Date { get; set; }
    }
}
