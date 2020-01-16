using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.BLL;
using Core.DAL;

namespace ShopV2.BLL.Interfaces
{
    public interface IProductService : Iservice<ProductBLL>
    {
        IEnumerable<ProductBLL> GetFiltered(ProductQueryBLL query);
        ProductBLL Find(int id);
        void Update(ProductBLL productBll);
        void Delete(int id);
    }
}
