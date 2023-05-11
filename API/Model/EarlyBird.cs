﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class EarlyBird
    {
        public int EarlyBirdID { get; set; }

        public double Percentage { get; set; }

        [Range(0, 999)]
        public int Limit { get; set; }

        [ForeignKey("EventID")]
        public int EventID { get; set; }
        public Event Event { get; set; }
    }
}
