using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Core.Domain; 

namespace ShoeStore.Core.Interfaces
{
    public interface ICartItemService
    {
        IList<CartItem> GetCartItems(int customerId);
        void AddCartItem(int customerId, int itemId, decimal unitPrice, int quantity);
        void RemoveCartItem(int cuctomerId, int itemId);
        void UpdateCartItemQuantity(int customerId, int itemId, int quantity);
    }
}
