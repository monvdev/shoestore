using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByUsername(string userName);
    }
}
