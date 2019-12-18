using System;
using System.Collections.Generic;
using System.Text;

namespace Core.WEB
{
    public class ProductWEB
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public int Sold { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
