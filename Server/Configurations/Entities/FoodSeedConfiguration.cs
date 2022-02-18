using FSD_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSD_Project.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    Id = 1,
                    FoodName = "Crispy Prata",
                    FoodStoreID = 1,
                    FoodPrice = 2
                    
                },
                new Food
                {
                    Id = 2,
                    FoodName = "Beef Wellington",
                    FoodStoreID = 2,
                    FoodPrice = 50
                }
            );
        }
    }
}
