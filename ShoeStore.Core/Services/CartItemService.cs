using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Interfaces;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Services
{
    public class CartItemService : ICartItemService
    {
        public CartItemService(IRepository<CartItem> cartItemBaseRepository, ICartItemRepository cartItemExtendedRepository) { }


        public void AddCartItem(int customerId, int itemId, decimal unitPrice, int quantity)
        {
            throw new NotImplementedException();
        }

        public IList<CartItem> GetCartItems(int customerId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCartItem(int cuctomerId, int itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItemQuantity(int cartId, int itemId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
