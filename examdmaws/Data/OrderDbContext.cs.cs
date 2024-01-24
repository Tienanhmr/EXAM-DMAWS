using examdmaws.Models;
using Microsoft.EntityFrameworkCore;

namespace examdmaws.Data
{
    // Data/OrderDbContext.cs
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString");
        }
    }

}
