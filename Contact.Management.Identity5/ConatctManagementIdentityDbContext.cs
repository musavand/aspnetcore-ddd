using System;
using System.Collections.Generic;
using System.Text;
using Contact.Management.Identity.Configurations;
using Contact.Management.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Contact.Management.Identity
{
    public class ConatctManagementIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ConatctManagementIdentityDbContext(DbContextOptions<ConatctManagementIdentityDbContext>  options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
