using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Display(Name = "Customer Type")]
        public string CustomerName { get; set; } = string.Empty;
        [Display(Name = "Customer Type")]
        public int CustomerTypeId { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; } = string.Empty;

    }
}
