using Contact.Managment.MVC.Models;
using Contact.Managment.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Contracts
{
    public interface ICustomerService
    {
        Task<List<CustomerVM>> GetCustomers();
        Task<CustomerVM> GetCustomerDetail(int id);
        Task<Response<int>> CreateCustomer(CreateCustomerVM customer);

        Task<Response<int>> UpdateCustomer(int Id , CustomerVM customer);
        Task<Response<int>> DeleteCustomer(int Id);
    }
}
