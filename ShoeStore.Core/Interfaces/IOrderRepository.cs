using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    public interface IOrderRepository
    {
        IList<Order> GetOrderByCustomer(int customerId);
    }
}
