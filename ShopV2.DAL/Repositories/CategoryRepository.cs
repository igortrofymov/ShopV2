using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;
using Microsoft.EntityFrameworkCore;
using ShopV2.DAL.Interfaces;

namespace ShopV2.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ShopDBContext db;

        public CategoryRepository(ShopDBContext db)
        {
            this.db = db;
        }

        public IQueryable<Category> GetAll()
        {
            return this.db.Categories.Include(c=>c.Products);
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }


        public int Create(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
            return item.Id;
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }
    }
}
