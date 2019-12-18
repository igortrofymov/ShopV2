using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.BLL;
using Core.DAL;
using Core.WEB;

namespace Core.Transformer
{
    class Resolver : Profile
    {
        public Resolver()
        {
            CreateMap<Product, ProductBLL>().PreserveReferences();
            CreateMap<List<Product>, List<ProductBLL>>().PreserveReferences();
            CreateMap<ProductBLL, ProductWEB>().PreserveReferences();
            CreateMap<List<ProductBLL>,List<ProductWEB>>().PreserveReferences();

            CreateMap<Category, CategoryBLL>().PreserveReferences();
            CreateMap<List<Category>, List<CategoryBLL>>().PreserveReferences();
            CreateMap<CategoryBLL, CategoryWEB>().PreserveReferences();
            CreateMap<List<CategoryBLL>, List<CategoryWEB>>().PreserveReferences();
        }
    }
}
