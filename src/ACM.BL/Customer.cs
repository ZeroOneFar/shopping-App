using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public static int CustomerCount { get; private set; }
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public string FullName
        {
            get
            {
                var name =FirstName;
                if (string.IsNullOrWhiteSpace(FirstName))
                    return !string.IsNullOrWhiteSpace(LastName) ? LastName : "No Name";
                if (string.IsNullOrWhiteSpace(LastName)) return name;
                name += ", " + LastName;
                return name;
            }
        }

        public Customer Retrieve(int customerId)
        {
            // work left to do
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            // work left to do
            return new List<Customer>();
        }
        public bool Validate()
        {
            bool isValide = !(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(LastName));
            return isValide;
        }
    }
}
