﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }=string.Empty;
    }
}
