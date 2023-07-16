using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        [Required]
        public string WarehouseName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Display(Name ="Branch")]
        public int BranchId { get; set; }

    }
}
