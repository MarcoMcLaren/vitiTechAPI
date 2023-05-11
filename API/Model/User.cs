﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(50)]
        public string UserEmail { get; set; }

        [MaxLength(50)]
        public string UserPassword { get; set; }

        [ForeignKey("CustomerID")]
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }

        [JsonIgnore]
        public List<SuperUser> SuperUsers { get; set; }

        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
