using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusID { get; set; }

        public string OrderStatusName { get; set; }

        [JsonIgnore]
        public List<Order> Orders { get; set; }
    }
}
