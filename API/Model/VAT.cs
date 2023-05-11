using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class VAT
    {
        [Key]
        public int VATID { get; set; }

        public double Percentage { get; set; }

        public DateTime Date { get; set; }
    }
}
