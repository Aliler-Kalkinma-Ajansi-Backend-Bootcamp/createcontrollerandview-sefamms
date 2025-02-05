﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodluyoruzWEB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
