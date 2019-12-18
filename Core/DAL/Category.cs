using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.DAL
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
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
