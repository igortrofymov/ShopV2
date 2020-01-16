using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DAL;
using Core.Extensions;
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
        public IQueryable<Product> GetAll()
        {

            return context.Products.Include(m=>m.Category);
        }

        public Product GetById(int id)
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
            context.Update<Product>(item);
            //context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Product product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public IQueryable<Product> GetSeveral(ProductQuery query)
        {

            IQueryable<Product> products = context.Products.Include(p=>p.Category);
            if (query.PriceFrom.HasValue)
            {
                products = products.Where(p => p.Price >= query.PriceFrom);
            }
            if (query.PriceTo.HasValue)
            {
                products = products.Where(p => p.Price <= query.PriceTo);
            }
            if (!String.IsNullOrEmpty(query.Name))
            {
                products = products.Where(p => p.Name.Contains(query.Name));
            }
            if (query.CategoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId==query.CategoryId);
            }

            string str;
            Expression<Func<Product, object>> exp;
            Dictionary<string, Expression<Func<Product, object>>> columnsMap =
                new Dictionary<string, Expression<Func<Product, object>>>()
                {
                    ["category"] = v => v.Category.Name,
                    ["price"] = p => p.Price,
                    ["name"] = p => p.Name
                };
            products = products.ApplyOrdering(query, columnsMap);

            return products;
        }

    }
}
