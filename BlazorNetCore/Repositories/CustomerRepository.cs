using BlazorNetCore.Data;
using BlazorNetCore.Data.Entities;
using BlazorNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNetCore.Repositories
{
    public class CustomerRepository : ICostumerRepository
    {
        private readonly DataContext _db;

        public CustomerRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<ResponseCustomers> GetAllCustomers()
        {
            try
            {
                List<Customer> customers = await _db.Customers.ToListAsync();

                return new ResponseCustomers { IsSuccess = true, Data = customers };
            }
            catch (Exception ex)
            {
                return new ResponseCustomers { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ResponseCustomer> GetCustomerDetail(int id)
        {
            try
            {
                Customer customer = await _db.Customers.FindAsync(id);
                return new ResponseCustomer { IsSuccess = true, Data = customer };
            }
            catch (Exception ex)
            {
                return new ResponseCustomer { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<Response> InsertCustomer(Customer customer)
        {
            try
            {
                _ = await _db.AddAsync(customer);
                _ = await _db.SaveChangesAsync();

                return new Response { IsSuccess = true, Message = "Registro creado satisfactoriamente." };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = true, Message = ex.Message };
            }
        }

        public async Task<Response> UpdateCustomer(Customer customer)
        {
            try
            {
                _ = _db.Update(customer);
                _ = await _db.SaveChangesAsync();

                return new Response { IsSuccess = true, Message = "Registro actualizado satisfactoriamente." };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<Response> DeleteCustomer(int id)
        {
            try
            {
                Customer customer = await _db.Customers.FindAsync(id);
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();

                return new Response { IsSuccess = true, Message = "Registro eliminado." };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
