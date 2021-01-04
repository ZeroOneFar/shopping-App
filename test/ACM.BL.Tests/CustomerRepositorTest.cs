using Xunit;

namespace ACM.BL.Tests
{
    public class CustomerRepositorTest
    {
        [Fact]
        public void repository_retrieves_and_saves_data()
        {
            var repo = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "John",
                LastName = "Paul",
                Email = "johnpaul@gmail.com"
            };
            //act
             var actual = repo.Retrieve(1);
            //assert
            Assert.Equal(expected.FirstName ,actual.FirstName);
            Assert.Equal(expected.LastName ,actual.LastName);
            Assert.Equal(expected.Email ,actual.Email);
            Assert.Equal(expected.CustomerId ,actual.CustomerId);
        }
    }
}