using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class ShippingDetails
    {
        [Key]
        public int ShippingID { get; set; }

        public DateTime ShippingDate { get; set; }

        [MaxLength(50)]
        public string TrackingNumber { get; set; }
    }
}
