using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FSD_Project.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        
        public string PaymentType { get; set; }
    }
}
