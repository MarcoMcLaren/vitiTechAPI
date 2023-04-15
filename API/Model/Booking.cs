using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }


        public DateTime BookingDate { get; set; }
    }
}
