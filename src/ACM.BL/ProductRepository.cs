namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // work left to do
            var product = new Product(productId);
            if (product.ProductId == 2)
            {
                product.CurrentPrice = 54.6M;
                product.ProductName = "LamboJet";
                product.ProductDescription = "Flying Lambo";
            }
            return product;
        }
        public bool Save(Product product)
        {
            //save this item into cloud or what ever.
            return true;
        }
    }
}