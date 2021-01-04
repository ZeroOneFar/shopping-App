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
            return true;
        }
    }
}