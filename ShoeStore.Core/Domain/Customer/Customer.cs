using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{ 
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
    }
}
