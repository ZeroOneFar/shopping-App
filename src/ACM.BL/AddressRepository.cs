﻿using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);
            if(addressId == 4)
            {
                address.AddressType = AddressType.Work;
                address.PostalCodeOrZipCode = 123456;
                address.StreetLine1 = "semester";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var list = new List<Address>();
            var ad1 = new Address(customerId)
            {
                AddressType = AddressType.Home,
                PostalCodeOrZipCode = 123546,
                StreetLine1 = "hello"
            };
            list.Add(ad1);
            return list;
        }

        public bool Save(Address address)
        {
            //save the state and then returns true
            return true;
        }
    }
}