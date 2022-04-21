﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Management.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id ="",
                    Name="Employee",
                    NormalizedName ="EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                );
        }
    }
}