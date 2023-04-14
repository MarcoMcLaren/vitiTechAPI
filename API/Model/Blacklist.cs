using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Blacklist
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(255)]
        public string Reason { get; set; }
    }
}
