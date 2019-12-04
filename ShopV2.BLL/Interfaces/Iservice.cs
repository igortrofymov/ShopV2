using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV2.BLL.Interfaces
{
    public interface Iservice<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}
