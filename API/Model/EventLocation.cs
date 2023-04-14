using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class EventLocation
    {
        [Key]
        public int EventLocationID { get; set; }

        [ForeignKey("AddressID")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        [MaxLength(100)]
        public string Street_Address { get; set; }

        [MaxLength(4)]
        public string Postal_Code { get; set; }

        public DateTime Date_of_last_update { get; set; }
    }
}
