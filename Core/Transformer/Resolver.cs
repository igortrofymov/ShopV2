using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.BLL;
using Core.DAL;
using Core.WEB;

namespace Core.Transformer
{
    public class Resolver : Profile
    {
        public Resolver()
        {
            CreateMap<Product, ProductBLL>().PreserveReferences();
            CreateMap<ProductBLL, ProductWEB>().PreserveReferences();
            CreateMap<ProductBLL, Product>().PreserveReferences();
            CreateMap<ProductWEB, ProductBLL>().PreserveReferences();

            CreateMap<Category, CategoryBLL>().PreserveReferences();
            CreateMap<CategoryBLL, CategoryWEB>().PreserveReferences();
            CreateMap<CategoryBLL,Category>().PreserveReferences();
            CreateMap<CategoryWEB, CategoryBLL>().PreserveReferences();

            CreateMap<ProductQueryBLL, ProductQuery>().PreserveReferences();
            CreateMap<ProductQueryWEB, ProductQueryBLL>().PreserveReferences();
            CreateMap<ProductQuery, ProductQueryBLL>().PreserveReferences();
            CreateMap<ProductQueryBLL, ProductQueryWEB>().PreserveReferences();
        }
    }
}
