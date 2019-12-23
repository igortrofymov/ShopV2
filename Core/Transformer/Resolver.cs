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


            CreateMap<Category, CategoryBLL>().PreserveReferences();
            CreateMap<CategoryBLL, CategoryWEB>().PreserveReferences();

            CreateMap<ProductFilterBLL, ProductFilter>().PreserveReferences();
            CreateMap<ProductFilterWEB, ProductFilterBLL>().PreserveReferences();

        }
    }
}
