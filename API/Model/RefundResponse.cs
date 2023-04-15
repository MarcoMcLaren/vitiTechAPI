using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class RefundResponse
    {
        [Key]
        public int RefundResponseID { get; set; }

        [MaxLength(8)]
        public string ResponseValue { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public List<Refund> Refunds { get; set; }
    }
}
