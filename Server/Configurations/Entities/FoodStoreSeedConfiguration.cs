using FSD_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSD_Project.Server.Configurations.Entities
{
    public class FoodStoreSeedConfiguration : IEntityTypeConfiguration<FoodStore>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FoodStore> builder)
        {
            builder.HasData(
                new FoodStore
                {
                    Id = 1,
                    FoodStoreName ="Prata House",
                    FoodStoreAddress = "Thomson Road",
                    FoodStoreArea = "Central",
                    FoodStoreQuantity = 100

                },
                new FoodStore
                {
                    Id = 2,
                    FoodStoreName = "Gordon Oliver's Fine Dining",
                    FoodStoreAddress = "Marina Bay Sands",
                    FoodStoreArea = "South",
                    FoodStoreQuantity = 100
                }
            );
        }
    }
}
