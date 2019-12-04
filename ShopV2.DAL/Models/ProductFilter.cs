﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV2.DAL.Models
{
    public class ProductFilter
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public string Name { get; set; }
        public List<int> CatIds { get; set; }

        public ProductFilter()
        {
            CatIds = new List<int>();
        }
    }
}
