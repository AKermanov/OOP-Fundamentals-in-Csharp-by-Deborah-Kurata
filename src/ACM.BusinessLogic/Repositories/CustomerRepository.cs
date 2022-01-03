﻿namespace ACM.BusinessLogic.Repositories
{
    using System.Linq;
    public class CustomerRepository
    {
        private readonly AddressRepository _addressRepository;
        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = _addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
