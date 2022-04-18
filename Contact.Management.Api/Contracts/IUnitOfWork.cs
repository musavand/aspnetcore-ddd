using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Management.Api.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        //IGenericRepository<Customer> LeaveTypes { get; }
      
        Task Save();
    }
}