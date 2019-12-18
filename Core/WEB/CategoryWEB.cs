using System;
using System.Collections.Generic;
using System.Text;

namespace Core.WEB
{
    public class CategoryWEB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductWEB> Products { get; set; }

        public CategoryWEB()
        {
            Products = new List<ProductWEB>();
        }
    }
}
