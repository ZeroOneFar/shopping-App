using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public sealed class Customer : EntityBase
    {
        public List<Address> CustomerAddresses { get; set; }
        public static int CustomerCount { get; private set; }
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer():this(0)
        {
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            CustomerAddresses = new List<Address>();
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

        public override string ToString() => FullName;

        public override bool Validate()
        {
            bool isValide = !(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(LastName));
            return isValide;
        }
    }
}
