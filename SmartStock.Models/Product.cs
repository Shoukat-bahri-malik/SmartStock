using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdcutName { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public string BarCode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public int MeasureUnitId { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        [Display(Name ="Currency")]
        public int CurrencyId { get; set; }
    }
}
