using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class InvoiceType
    {
        public int InvoiceTypeId { get; set; }
        public string InvoiceTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
