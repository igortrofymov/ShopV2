using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;
using Microsoft.EntityFrameworkCore;
using ShopV2.DAL.Interfaces;

namespace ShopV2.DAL.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private ShopDBContext context;

        public ProductRepository(ShopDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return context.Products.Include(m=>m.Category);
        }

        public Product GetById(string id)
        {
            return context.Products.Find(id);
        }

        public int Create(Product item)
        {
            context.Products.Add(item);
            context.SaveChanges();
            return item.ProductId;
        }

        public void Update(Product item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteById(string id)
        {
            Product product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public IQueryable<Product> GetSeveral(ProductFilter filter)
        {

            IQueryable<Product> products = context.Products;
            if (filter.PriceFrom != null)
            {
                products = products.Where(p => p.Price > filter.PriceFrom);
            }
            if (filter.PriceTo != null)
            {
                products = products.Where(p => p.Price < filter.PriceTo);
            }
            if (filter.Name != null)
            {
                products = products.Where(p => p.Name.Contains(filter.Name));
            }
            if (filter.CatId != null)
            {
                products = products.Where(p => p.CategoryId==filter.CatId);
            }

            return products;
        }
    }
}
