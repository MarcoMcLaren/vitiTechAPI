using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class FAQ
    {
        [Key]
        public int FAQID { get; set; }

        [MaxLength(255)]
        public string Question { get; set; }

        [MaxLength(255)]
        public string Answer { get; set; }
    }
}
