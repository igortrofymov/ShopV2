using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV2.BLL.DTO
{
    public class ProductFilterDTO
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> CatIds { get; set; }

        public ProductFilterDTO()
        {
            CatIds = new List<int>();
        }
    }
}