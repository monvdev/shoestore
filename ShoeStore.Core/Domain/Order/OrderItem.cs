using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ShoeId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceWithTax { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithTax { get; set; }
        public decimal Discount { get; set; }
        public decimal DicountWithTax { get; set; }
    }
}
