using BlazorNetCore.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNetCore.Data
{
    public class DbInitializer
    {
        private readonly DataContext _db;
        public DbInitializer(DataContext db)
        {
            _db = db;
        }

        public async Task SeedAsync()
        {
            await _db.Database.EnsureCreatedAsync();
            await CheckCustomerAsync();
        }

        private async Task CheckCustomerAsync()
        {
            if (!_db.Customers.Any())
            {
                await AddCustomer("123456789", "Pedro Perez", "Miami");
                await AddCustomer("234567891", "Juan Diaz", "Chicago");
                await AddCustomer("345678912", "Carolina Torres", "New York");
                await AddCustomer("456789123", "John Arevalo", "Los Angeles");
                await AddCustomer("567891234", "Maria Perez", "Miami");
            }
        }

        private async Task AddCustomer(string customerId, string customerName, string customerCity)
        {
            _db.Customers.Add(new()
            {
                Customer_id = customerId,
                Customer_name = customerName,
                Customer_city = customerCity
            });

            await _db.SaveChangesAsync();
        }
    }
}
