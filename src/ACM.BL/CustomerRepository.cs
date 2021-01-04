using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        private readonly AddressRepository _addressRepository;
        public Customer Retrieve(int customerId)
        {
            // work left to do
            var customer =  new Customer(customerId);

            if (customerId != 1) return customer;
            customer.FirstName = "John";
            customer.LastName = "Paul";
            customer.Email = "johnpaul@gmail.com";
            customer.CustomerAddresses = _addressRepository.RetrieveByCustomerId(customerId).ToList();
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;
            if (!customer.HasChanges) return success;
            if (customer.IsValid)
            {
                if (customer.IsNew)
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