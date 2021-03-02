using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Complete,
        Cancelled
    }
}
