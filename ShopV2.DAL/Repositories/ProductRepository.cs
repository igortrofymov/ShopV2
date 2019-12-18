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
            throw new NotImplementedException();
        }

        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetSeveral()
        {
            throw new NotImplementedException();
        }
    }
}
