using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestTaskWebApi.Domain.Core;
using TestTaskWebApi.Domain.Interfaces;

namespace TestTaskWebApi.Infrastructure.Data
{
    public class OrderRepository : IOrderRepository
    {
        private OrderContext db;
        
        public OrderRepository(OrderContext db)
        {
            this.db = db;
        }
        public IEnumerable<Order> GetOrders(int id)
        {
            IEnumerable<Order> orders = db.Orders.Where(x => x.Client.Id == id);
            return orders;
        }

        public IEnumerable<Order> GetOrders(DateTime dateTime)
        {
            IEnumerable<Order> orders = db.Orders.Where(d => d.CreateTime.Date == dateTime.Date);
            return orders;
        }

        public IEnumerable<Order> GetOrders()
        {
            IEnumerable<Order> orders = db.Orders.ToList();
            return orders;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
