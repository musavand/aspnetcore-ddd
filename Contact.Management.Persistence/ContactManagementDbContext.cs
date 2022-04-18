using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Contact.Management.Domain;
using System.Threading.Tasks;
using System.Threading;
using Contact.Management.Domain.Common;
namespace Contact.Management.Persistence
{
    public class ContactManagementDbContext : DbContext
    {
        public ContactManagementDbContext(DbContextOptions<ContactManagementDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContactManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //base.OnModelCreating(modelBuilder);
            return base.SaveChangesAsync(cancellationToken);
            foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entity.Entity.LastModifyDate = DateTime.Now;
                if (entity.State == EntityState.Added)
                    entity.Entity.DateCreated = DateTime.Now;
            }
        }
    }
}
