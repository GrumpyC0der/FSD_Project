using FSD_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSD_Project.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    CustomerName = "Iaian",
                    CustomerAddress = "Sengkang",
                    CustomerContact = 98765432

                },
                new Customer
                {
                    Id = 2,
                    CustomerName = "Wei Jian",
                    CustomerAddress = "Hillview",
                    CustomerContact = 89765432
                }
            );
        }
    }
}