using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [MaxLength(255)]
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        public int Tickets_Available { get; set; }

        public int Tickets_Sold { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int EarlyBird { get; set; }

        [MaxLength(255)]
        public string Image_URL { get; set; }


        [ForeignKey("EventPriceID")]
        public int EventPriceID { get; set; }
        public EventPrice EventPrice { get; set; }


        [ForeignKey("EventTypeID")]
        public int EventTypeID { get; set; }
        public EventType EventType { get; set; }

        public List<Booking> Bookings { get; set; }

    }
}
