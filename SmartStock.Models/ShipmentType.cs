using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class ShipmentType
    {
        public int Id { get; set; }
        public string ShipmentTypeName { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
