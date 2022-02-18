using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Project.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public Order()
        {
            this.OrderItem = new HashSet<OrderItem>();
        }
        public DateTime OrderTime { get; set; }
        public float OrderFee { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int PaymentID { get; set; }
        public virtual Payment Payment { get; set; }
        public int OrderItemID { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
