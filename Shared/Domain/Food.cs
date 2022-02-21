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
        [Required]
        [DataType(DataType.Currency)]
        public float FoodPrice { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string FoodName { get; set; }
        [Required]
        public int FoodStoreID { get; set; }
        public virtual FoodStore FoodStore { get; set; }
}
}
