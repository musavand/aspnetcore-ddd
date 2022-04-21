using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Management.Identity.Configurations
{
    public class UserRoleConfiguration  : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>>  builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId ="",
                    RoleId =""
                },
                new IdentityUserRole<string>
                {
                    UserId = "",
                    RoleId = ""
                }
                );
        }
    }
}
