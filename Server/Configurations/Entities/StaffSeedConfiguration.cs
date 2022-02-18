using System;
using FSD_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FSD_Project.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffName = "Nicholas",
                    StaffPosition = "Deliverer",
                    StaffContact = 100

                },
                new Staff
                {
                    Id = 2,
                    StaffName = "Evan",
                    StaffPosition = "Store Staff",
                    StaffContact = 100
                }
            );
        }

    }
}
