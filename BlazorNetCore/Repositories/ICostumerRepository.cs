using BlazorNetCore.Data.Entities;
using BlazorNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorNetCore.Repositories
{
    public interface ICostumerRepository
    {
        Task<ResponseCustomers> GetAllCustomers();
        Task<ResponseCustomer> GetCustomerDetail(int id);
        Task<Response> InsertCustomer(Customer customer);
        Task<Response> UpdateCustomer(Customer customer);
        Task<Response> DeleteCustomer(int id);
    }
}
