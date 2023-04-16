using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime Date_of_last_update { get; set; }

        public List<City> Cities { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
