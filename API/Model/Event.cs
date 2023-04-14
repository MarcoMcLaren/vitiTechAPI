﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("EventTypeID")]
        public int EventTypeID { get; set; }
        public EventType EventType { get; set; }

        [ForeignKey("EventLocationID")]
        public int EventLocationID { get; set; }
        public EventLocation EventLocation { get; set; }

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