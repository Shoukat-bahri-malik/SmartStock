using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class NumberSequence
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Module { get; set; } = string.Empty;
        [Required]
        public string Prefix { get; set; } = string.Empty;
        public int LastNumber { get; set; }
    }
}
