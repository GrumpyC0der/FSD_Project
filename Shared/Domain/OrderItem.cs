using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Project.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderQuantity { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }

    }
}
