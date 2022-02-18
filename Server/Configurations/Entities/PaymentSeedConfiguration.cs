using FSD_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSD_Project.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    PaymentType = "Cash"

                },
                new Payment
                {
                    Id = 2,
                    PaymentType = "Credit Card"
                },
                new Payment
                {
                    Id = 3,
                    PaymentType = "Mobile Payment"
                }
            );
        }
    }
}