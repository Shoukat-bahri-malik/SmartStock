using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class BillType
    {
        public int BillTypeId { get; set; }
        public string BillTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
