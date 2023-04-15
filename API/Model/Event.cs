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
        public string image_URL { get; set; }
    }
}
