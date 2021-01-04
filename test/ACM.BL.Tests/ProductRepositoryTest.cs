using Xunit;

namespace ACM.BL.Tests
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void retrieves_similarObject_from_repo()
        {
            //arrange
            var repo = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 54.6M,
                ProductName = "LamboJet",
                ProductDescription = "Flying Lambo",
            };
            //act
            var actual = repo.Retrieve(2);
            //assert
            Assert.Equal(expected.CurrentPrice , actual.CurrentPrice);
            Assert.Equal(expected.ProductName,actual.ProductName);
            Assert.Equal(expected.ProductId,actual.ProductId);
        }
    }
}

