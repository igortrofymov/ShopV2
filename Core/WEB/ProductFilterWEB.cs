﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.WEB
{
    public class ProductFilterWEB
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public string Name { get; set; }
        public int CatId { get; set; }

    }
}
