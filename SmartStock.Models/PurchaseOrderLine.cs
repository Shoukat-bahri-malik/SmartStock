﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartStock.Models
{
    public class PurchaseOrderLine
    {
        public int Id { get; set; }
        [Display(Name = "Purchase Order")]
        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }=string.Empty;
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        [Display(Name = "Discount Percentage")]
        public double DiscountPercentage { get; set; }
        [Display(Name = "Discount Amount")]
        public double DiscountAmount { get; set; }
        [Display(Name = "Sub Total")]
        public double SubTotal { get; set; }
        [Display(Name = "Tax Percentage")]
        public double TaxPercentage { get; set; }
        public double TaxAmount { get; set; }
        public double Total { get; set; }
    }
}
