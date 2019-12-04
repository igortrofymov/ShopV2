using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopV2.DAL.Models;

namespace ShopV2.DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetSeveral();
    }
}
