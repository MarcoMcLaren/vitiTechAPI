﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class EventPrice
    {
        [Key]
        public int EventPriceID { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public Event Event { get; set; }
    }
}
