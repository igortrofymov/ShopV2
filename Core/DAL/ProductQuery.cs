using System;
using System.Collections.Generic;
using System.Text;
using Core.Extensions;

namespace Core.DAL
{
    public class ProductQuery  : IQueryObject
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string SortBy { get ; set; }
        public bool IsSortAscending { get ; set ; }
    }
}
