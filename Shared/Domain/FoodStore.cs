using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FSD_Project.Shared.Domain
{
    public class FoodStore : BaseDomainModel
    { 
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string FoodStoreName { get; set; }
        [Required]
        public string FoodStoreAddress { get; set; }
        [Required]
        public int FoodStoreQuantity { get; set; }
        [Required]
        public string FoodStoreArea { get; set; }
    }
}
