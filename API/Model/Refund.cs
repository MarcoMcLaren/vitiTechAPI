using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Refund
    {
        [Key]
        public int RefundID { get; set; }

        public int Quantity_Refunded { get; set; }
        public DateTime Date_Issued { get; set; }
        public DateTime? Resolved_Date { get; set; }
    }
}
