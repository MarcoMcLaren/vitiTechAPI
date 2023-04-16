using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime Date_of_last_update { get; set; }

        public List<Region> Regions { get; set; }
    }
}
