using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopV2.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
