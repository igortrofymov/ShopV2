﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.WEB
{
    public class ProductQueryWEB
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }

    }
}
