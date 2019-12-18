using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.BLL;
using Core.DAL;
using Core.WEB;

namespace ShopV2.WEB
{
     class Resolver : Profile
    {
        public Resolver()
        {
            CreateMap<Product, ProductBLL>().PreserveReferences();
            CreateMap<ProductBLL, ProductWEB>().PreserveReferences();
            

            CreateMap<Category, CategoryBLL>().PreserveReferences();
            CreateMap<CategoryBLL, CategoryWEB>().PreserveReferences();
          
        }
    }
}
