using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        public DateTime BookingDate { get; set; }

        [ForeignKey("EventID")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<Ticket> Tickets { get; set; }

        public BookingPayment BookingPayment { get; set; }

        [ForeignKey("CustomerID")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
