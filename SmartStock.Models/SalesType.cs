using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class SalesType
    {
        public int SalesTypeId { get; set; }
        [Required]
        public string SalesTypeName { get; set; }
        public string Description { get; set; }
    }
}

