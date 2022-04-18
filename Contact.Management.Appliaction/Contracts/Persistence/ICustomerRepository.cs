using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contact.Management.Domain;


namespace Contact.Management.Appliaction.Contracts.Persistence
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {

        Task<Customer> GetCustomerDetail(int id);
        Task<List<Customer>> GetCustomerList();
    }
}
