using Microsoft.EntityFrameworkCore;
 
namespace CoffeWebApp.Models
{
    public class CoffeMachineContext : DbContext
    {
        public DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public DbSet<Order> Orders { get; set; }
 
        public CoffeMachineContext(DbContextOptions<CoffeMachineContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}