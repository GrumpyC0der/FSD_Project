using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FSD_Project.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        public float FoodPrice { get; set; }
        public string FoodName { get; set; }
        public int FoodStoreID { get; set; }
        public virtual FoodStore FoodStore { get; set; }
}
}
