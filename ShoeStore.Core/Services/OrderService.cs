using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Interfaces;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Services
{
    public class OrderService : IOrderService
    {
        public OrderService(IRepository<Order> orderBaseRepository, IOrderRepository orderExtendedRepository) { }


        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetOrderByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
