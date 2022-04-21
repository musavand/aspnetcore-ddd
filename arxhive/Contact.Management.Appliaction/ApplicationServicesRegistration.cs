using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Contact.Management.Appliaction.Profiles;
using MediatR;


namespace Contact.Management.Appliaction
{
    public static class ApplicationServicesRegistration
    {
        //register all needed services  in this class library
        //this method calls when ????
        //public static void ConfigureApplicationServices(this IServiceCollection  services )
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            //this id more beter
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
