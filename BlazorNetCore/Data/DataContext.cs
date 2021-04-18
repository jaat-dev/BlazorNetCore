using BlazorNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorNetCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}