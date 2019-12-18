using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Core.BLL;
using Core.DAL;
using Core.WEB;
using ShopV2.BLL.Interfaces;
using ShopV2.DAL.Interfaces;

namespace ShopV2.BLL.Services
{
    public class ProductService : IProductService
    {
        private IMapper mapper;
        private IProductRepository productRepository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public IEnumerable<ProductBLL> GetAll()
        {
            var allProducts = productRepository.GetAll().ToList();
           var allProductsDto = mapper.Map<List<ProductBLL>>(allProducts);
           return allProductsDto;
        }

    }
}
