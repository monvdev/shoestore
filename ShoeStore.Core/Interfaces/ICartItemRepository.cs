using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    public interface ICartItemRepository
    {
        void UpdateCartItemQuantity(int customerId, int itemId, int quantity);
        IList<CartItem> GetCartItemsByCustomer(int cusntomerId);
    }
}
