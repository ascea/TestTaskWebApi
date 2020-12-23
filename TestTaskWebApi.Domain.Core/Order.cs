using System;

namespace TestTaskWebApi.Domain.Core
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal Sum { get; set; }

        public virtual Client Client { get; set; }
    }
}
