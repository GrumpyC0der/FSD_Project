using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Project.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StaffName { get; set; }
        public int StaffContact { get; set; }
        public string StaffPosition { get; set; }
    }
}
