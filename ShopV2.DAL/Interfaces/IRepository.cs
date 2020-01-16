using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;

namespace ShopV2.DAL.Interfaces
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        int  Create(T item);
        void Update(T item);
        void DeleteById(int id);
    }
}
