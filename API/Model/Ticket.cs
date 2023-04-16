using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        public double TicketPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        [ForeignKey("BookingID")]
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
