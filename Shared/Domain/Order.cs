using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FSD_Project.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public Order()
        {
            this.OrderItem = new HashSet<OrderItem>();
        }
        [DataType(DataType.Date)]
        public DateTime OrderTime { get; set; }
        [DataType(DataType.Currency)]
        public float OrderFee { get; set; }
        [Required]
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public int PaymentID { get; set; }
        public virtual Payment Payment { get; set; }
        [Required]
        public int OrderItemID { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
