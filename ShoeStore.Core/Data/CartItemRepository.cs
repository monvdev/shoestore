using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;
using ShoeStore.Core.Interfaces;

namespace ShoeStore.Core.Data
{
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShoeStoreContext context) : base(context)
        {
        }

        public IList<CartItem> GetCartItemsByCustomer(int cusntomerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItemQuantity(int customerId, int itemId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
