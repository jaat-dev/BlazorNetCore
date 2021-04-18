using BlazorNetCore.Data.Entities;
using BlazorNetCore.Models;
using BlazorNetCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNetCore.Services
{
    public class CustomerService : ICostumerService
    {
        private readonly ICostumerRepository _repository;

        public CustomerService(ICostumerRepository repository)
        {
            _repository = repository;
        }

        public Task<Response> DeleteCustomer(int id)
        {
            return _repository.DeleteCustomer(id);
        }

        public async Task<ResponseCustomers> GetAllCustomers()
        {
            return await _repository.GetAllCustomers();
        }

        public async Task<ResponseCustomer> GetCustomerDetail(int id)
        {
            return await _repository.GetCustomerDetail(id);
        }

        public async Task<Response> SaveCustomer(Customer customer)
        {
            if (customer.Id == 0)
                return await _repository.InsertCustomer(customer);
            else
                return await _repository.UpdateCustomer(customer);                
        }
    }
}
