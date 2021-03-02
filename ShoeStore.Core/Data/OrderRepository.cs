using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Interfaces;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Data
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ShoeStoreContext context) : base(context)
        {
        }

        public IList<Order> GetOrderByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
