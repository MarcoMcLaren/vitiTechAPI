using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        [ForeignKey("BookingID")]
        public int BookingID { get; set; }
        public Booking Booking { get; set; }

        public double TicketPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
