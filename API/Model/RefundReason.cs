using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class RefundReason
    {
        [Key]
        public int RefundReasonID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
    }
}
