using Microsoft.EntityFrameworkCore;
using TestTaskWebApi.Domain.Core;

namespace TestTaskWebApi.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
