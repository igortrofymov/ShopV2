using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;

namespace ShopV2.DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetSeveral();
    }
}
