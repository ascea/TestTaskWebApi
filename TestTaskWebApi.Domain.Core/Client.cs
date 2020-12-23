using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskWebApi.Domain.Core
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
