using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly ContactManagementDbContext _dbContext;
        public CustomerRepository(ContactManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Customer> GetCustomerDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetCustomerList()
        {
            throw new NotImplementedException();
        }
    }
}