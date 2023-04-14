using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class EarlyBird
    {
        [Key]
        public int EarlyBirdID { get; set; }

        public double Percentage { get; set; }

        [Range(0, 999)]
        public int Limit { get; set; }
    }
}
