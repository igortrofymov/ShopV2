using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV2.DAL.Interfaces
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        int  Create(T item);
        void Update(T item);
        void DeleteById(string id);
    }
}
