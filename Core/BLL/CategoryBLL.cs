using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BLL
{
    public class CategoryBLL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductBLL> Products { get; set; }

        public CategoryBLL()
        {
            Products = new List<ProductBLL>();
        }
    }
}
