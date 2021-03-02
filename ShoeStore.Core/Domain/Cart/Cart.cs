using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class Cart
    {
        public int CustomerId { get; set; }
        public IList<int> CartItems { get; set; }
    }
}
