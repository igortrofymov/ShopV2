using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.BLL;

namespace ShopV2.BLL.Interfaces
{
    public interface Iservice<T> where T:class
    {
        IEnumerable<T> GetAll();
        int Create(T item);

    }
}
