using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(int orderId);
        IList<Order> GetOrderByCustomer(int customerId);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
