using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
