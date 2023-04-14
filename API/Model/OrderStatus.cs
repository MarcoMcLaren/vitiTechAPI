using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusID { get; set; }

        public string OrderStatusName { get; set; }
    }
}
