using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);
            if (orderId == 3)
            {
                order.orderDate = new DateTimeOffset(DateTime.Now.Year,
                    1, 1, 10, 10, 00,
                    new TimeSpan(5, 30, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            var success = true;
            if (!order.HasChanges) return success;
            if (order.IsValid)
            {
                if (order.IsNew)
                {
                    //call and insert stored procedure
                }
                else
                {
                    //calls an Update stored procedure
                }
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}