using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order :EntityBase
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? orderDate { get; set; }
        
        public Order():this(0)
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public override string ToString()
        {
            return $"date :{orderDate} id: {OrderId}";
        }

        public override bool Validate()
        {
            return orderDate != null && OrderId > 0;
        }
    }
}