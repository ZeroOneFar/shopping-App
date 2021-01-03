using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal? PurchasePrice { get; private set; }

        public bool Validate()
        {
            var isValid = (ProductId > 0  && Quantity >0 &&
                           PurchasePrice != null);
            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
    }
}