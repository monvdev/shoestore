using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOrdered { get;  set; } 
        public int OrderStatusId { get; set; }
        public int ShipAddressId { get; set; }        
        public int ShipStatusId { get; set; }
        public int BillingAddressId { get; set; }        
        public decimal DiscountAmount { get; set; }
        public decimal SubTotalAmountBeforeDiscount { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TaxAMount { get; set; }
        public decimal TotalAmount { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int CardExpireMonth { get; set; }
        public int CardExpireYear { get; set; }
        public string NameInCard { get; set; }
        public string CardCVV { get; set; }

    }
}
