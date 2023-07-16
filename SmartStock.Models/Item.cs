using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Item: BaseEntity
    {
       
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AvailbleQuantity { get; set; }
        public int MyProperty { get; set; }

        public Status Status { get; set; }
    }
}

namespace SmartStock.Models
{
    public enum Status
    {
        Ok,Defective
    }
}