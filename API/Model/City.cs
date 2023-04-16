﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime Date_of_last_update { get; set; }

        public List<Address> Addresses { get; set; }

        [ForeignKey("Region")]
        public int RegionID { get; set; }
        public Region Region { get; set; }
    }
}
