using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml;

namespace Core.DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public int Sold { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
