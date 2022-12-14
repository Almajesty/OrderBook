using Microsoft.EntityFrameworkCore;
using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Persistence.Context;

public class ApplicationContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=OrderBookDataBase.db");
    }
}
