﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class Varietal
    {
        [Key]
        public int VarietalID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [JsonIgnore]
        public List<Wine> Wines { get; set; }
    }
}
