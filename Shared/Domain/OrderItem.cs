using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FSD_Project.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        
        public int OrderQuantity { get; set; }
        [Required]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }

    }
}
