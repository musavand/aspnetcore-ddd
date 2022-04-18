using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contact.Management.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContactManagementDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("ContactManagementConnectionString")
                )
            );
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
           
            return services;

        }
    }
}