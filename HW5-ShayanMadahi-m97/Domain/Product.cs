﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ShayanMadahi_m97.Domain
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public Product(int productId, string name, string barcode)
        {
            ProductId = productId;
            Name = name;
            Barcode = barcode;
        }
    }
}
