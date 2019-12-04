using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ShopV2.BLL.DTO;
using ShopV2.DAL.Models;

namespace ShopV2.BLL.Services
{
    public class MapResolver : Profile
    {
        public MapResolver()
        {
            CreateMap<Product, ProductDTO>().PreserveReferences();
            CreateMap<IEnumerable<Product>, IEnumerable<ProductDTO>>().PreserveReferences();
        }
    }
}
