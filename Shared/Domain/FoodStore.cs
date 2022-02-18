using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Project.Shared.Domain
{
    public class FoodStore : BaseDomainModel
    { 
        public string FoodStoreName { get; set; }
        public string FoodStoreAddress { get; set; }
        public int FoodStoreQuantity { get; set; }
        public string FoodStoreArea { get; set; }
    }
}
