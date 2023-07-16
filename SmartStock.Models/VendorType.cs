using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class VendorType
    {
        public int VendorTypeId { get; set; }
        [Required]
        public string VendorTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
