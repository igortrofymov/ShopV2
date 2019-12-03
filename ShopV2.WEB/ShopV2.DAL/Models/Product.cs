using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopV2.DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public int Sold { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
