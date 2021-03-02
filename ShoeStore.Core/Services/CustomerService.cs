using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;
using ShoeStore.Core.Interfaces;

namespace ShoeStore.Core.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService(IRepository<Customer> customerBaseRepository, ICustomerRepository customerExtendedRepository) { }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByUsername(string userName)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
