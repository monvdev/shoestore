using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    interface ICustomerService
    {
        IList<Customer> GetCustomers();
        Customer GetCustomer(int customerId);
        Customer GetCustomerByUsername(string userName);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
