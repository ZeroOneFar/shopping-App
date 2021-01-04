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
            var success = true;
            if (!product.HasChanges) return success;
            if (product.IsValid)
            {
                if (product.IsNew)
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