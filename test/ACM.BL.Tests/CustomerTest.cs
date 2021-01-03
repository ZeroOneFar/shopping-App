using System;
using Xunit;

namespace ACM.BL.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void returns_fullName_correct_given_first_and_Last_names()
        {
            //arrange
            var customer = new Customer {FirstName = "David", LastName = "Ming"};
            //act
            string name = customer.FullName;
            //assert
            Assert.Equal("David, Ming",name);
        }
        [Fact]
        public void returns_fullName_correct_given_first_name_only()
        {
            //arrange
            var customer = new Customer {FirstName = "David", LastName = " "};
            //act
            string name = customer.FullName;
            //assert
            Assert.Equal("David",name);
        }
        [Fact]
        public void returns_fullName_correct_given_last_name_only()
        {
            //arrange
            var customer = new Customer {FirstName = "", LastName = "David"};
            //act
            string name = customer.FullName;
            //assert
            Assert.Equal("David",name);
        }
        [Fact]
        public void returns_fullName_correct_if_both_first_and_Last_are_empty()
        {
            //arrange
            var customer = new Customer {FirstName = "", LastName = ""};
            //act
            string name = customer.FullName;
            //assert
            Assert.Equal("No Name",name);
        }
        [Fact]
        public void counts_The_Customer_Numbers_Correctly_in_any_situation_valid()
        {
            //arrange
            var customer1 = new Customer();
            var customer2 = new Customer();
            var customer3 = new Customer();
            //act
            int count = Customer.CustomerCount;
            //assert
            Assert.Equal(3,count);
        }

        [Fact]
        public void ValidMethod_returns_correctly()
        {
            var customer = new Customer();
            customer.Email = "hello@gmail.com";
            customer.LastName = "sam";
            var customer1 = new Customer();
            customer1.Email = "hello@gmail.com";

            var return1 = customer.Validate();
            var return2 = customer1.Validate();
            
            Assert.True(return1);
            Assert.False(return2);
        }
    }
}
