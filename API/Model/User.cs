using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
