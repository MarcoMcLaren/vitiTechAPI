﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime Order_Date { get; set; }

        [ForeignKey("ShippingID")]
        public int ShippingID { get; set; }
        public ShippingDetails ShippingDetails { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public OrderPayment OrderPayment { get; set; }

        [JsonIgnore]
        public List<OrderItem> OrderItems { get; set; }

        [ForeignKey("OrderStatusID")]
        public int OrderStatusID { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
