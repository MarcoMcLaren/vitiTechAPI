using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class BookingPayment
    {
        [Key]
        public int PaymentID { get; set; }

        public double PaymentAmount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
