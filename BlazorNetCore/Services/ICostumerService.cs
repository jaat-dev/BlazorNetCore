using BlazorNetCore.Data.Entities;
using BlazorNetCore.Models;
using System.Threading.Tasks;

namespace BlazorNetCore.Services
{
    interface ICostumerService
    {
        Task<ResponseCustomers> GetAllCustomers();
        Task<ResponseCustomer> GetCustomerDetail(int id);
        Task<Response> SaveCustomer(Customer customer);
        Task<Response> DeleteCustomer(int id);
    }
}
