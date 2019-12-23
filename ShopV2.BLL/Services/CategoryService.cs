using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.BLL;
using ShopV2.BLL.Interfaces;
using ShopV2.DAL.Interfaces;

namespace ShopV2.BLL.Services
{
    public class CategoryService : ICategoryService
    {


        private ICategoryRepository repository;
        private IMapper mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        public IEnumerable<CategoryBLL> GetAll()
        {
            var cats = repository.GetAll();
           var  catsBLL = mapper.Map<List<CategoryBLL>>(cats);
           return catsBLL;
        }

        public int Create(CategoryBLL item)
        {
            throw new NotImplementedException();
        }
    }
}
