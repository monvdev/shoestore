using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public string NameInCard { get; set; }
    }
}
