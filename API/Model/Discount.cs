using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        [MaxLength(50)]
        public string Discount_Code { get; set; }

        [MaxLength(50)]
        public string Discount_Type { get; set; }

        public double Discount_Amount { get; set; }

        public List<WineDiscount> WineDiscounts { get; set; }
    }
}
