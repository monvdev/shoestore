using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CustomerId { get; set; }
        public int ShoeId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
