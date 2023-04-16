using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [MaxLength(100)]
        public string Street_Address { get; set; }

        [MaxLength(4)]
        public string Postal_Code { get; set; }

        public DateTime Date_of_last_update { get; set; }

        [ForeignKey("CityID")]
        public int CityID { get; set; }
        public City City { get; set; }

        [ForeignKey("CustomerID")]
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }

        public List<SuperUser> SuperUsers { get; set; }
    }
}
