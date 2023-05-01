using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        [MaxLength(50)]
        public string DiscountCode { get; set; }

        [MaxLength(50)]
        public string DiscountType { get; set; }

        public double DiscountAmount { get; set; }

        public List<WineDiscount> WineDiscounts { get; set; }
    }
}
