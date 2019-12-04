using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ShopV2.BLL.DTO;
using ShopV2.BLL.Interfaces;
using ShopV2.DAL.Interfaces;

namespace ShopV2.BLL.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        private IMapper mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public IEnumerable<ProductDTO> GetAll()
        {
            var allProducts = productRepository.GetAll();
            List<ProductDTO> allProductsDto = new List<ProductDTO>();
            foreach (var product in allProducts)
            {
                allProductsDto.Add(mapper.Map< ProductDTO>(product));
            }
            return allProductsDto;
        }
    }
}
