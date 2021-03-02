using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class CustomerPayment
    {
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public int BillingAddressId { get; set; }
        public bool Default { get; set; }

    }
}
