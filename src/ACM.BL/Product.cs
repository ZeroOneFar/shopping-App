using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {
        public int ProductId { get; private set;}
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public Product()
        {
            
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        
        
        public Product Retrieve(int customerId)
        {
            // work left to do
            return new Product();
        }
        public List<Product> Retrieve()
        {
            // work left to do
            return new List<Product>();
        }

        public bool Save()
        {
            //save this item into cloud or what ever.
            return true;
        }
        
        public bool Validate()
        {
            var isValid = !(string.IsNullOrWhiteSpace(ProductName) || ProductId == 0);
            return isValid;
        }
    }
}