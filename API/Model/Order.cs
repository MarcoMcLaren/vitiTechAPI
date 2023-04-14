using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("ShippingID")]
        public int ShippingID { get; set; }
        public ShippingDetails Shipping { get; set; }

        [ForeignKey("OrderStatusID")]
        public int OrderStatusID { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public DateTime Order_Date { get; set; }
    }
}
