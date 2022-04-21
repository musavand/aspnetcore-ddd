using Contact.Management.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Management.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "",
                    Email = "Employee",
                    NormalizedEmail = "EMPLOYEE",
                    FirstName="",
                    LastName="",
                    UserName = "Employee",
                    NormalizedUserName = "EMPLOYEE",
                    PasswordHash =hasher.HashPassword(null,"P@ssword1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "",
                    Email = "Employee",
                    NormalizedEmail = "EMPLOYEE",
                    FirstName = "",
                    LastName = "",
                    UserName = "Employee",
                    NormalizedUserName = "EMPLOYEE",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2"),
                    EmailConfirmed = true,
                }
                );
        }
    }
}