using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? orderDate { get; set; }

        public bool Validate()
        {
            return orderDate != null && OrderId > 0;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            //save this order
            return true;
        }
    }
}