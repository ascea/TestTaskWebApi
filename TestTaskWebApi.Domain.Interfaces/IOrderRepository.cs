using System;
using System.Collections.Generic;
using TestTaskWebApi.Domain.Core;

namespace TestTaskWebApi.Domain.Interfaces
{
    public interface IOrderRepository : IDisposable
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(int id);
        IEnumerable<Order> GetOrders(DateTime dateTime);
    }
}
