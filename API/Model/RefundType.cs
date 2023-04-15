using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class RefundType
    {
        [Key]
        public int RefundTypeID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public List<RefundReason> RefundReasons { get; set; }
    }
}
