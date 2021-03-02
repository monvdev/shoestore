using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; } 
        public bool Default { get; set; }
    }
}
