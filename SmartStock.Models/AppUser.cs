
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class appuser : IdentityUser
    {
        public string name { get; set; } 
        public string address { get; set; }
        public string city { get; set; } 
        public string pincode { get; set; }
    }
}
