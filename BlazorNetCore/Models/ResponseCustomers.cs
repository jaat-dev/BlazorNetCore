using BlazorNetCore.Data.Entities;
using System.Collections.Generic;

namespace BlazorNetCore.Models
{
    public class ResponseCustomers : Response
    {
        public IEnumerable<Customer> Data { get; set; }
    }
}
