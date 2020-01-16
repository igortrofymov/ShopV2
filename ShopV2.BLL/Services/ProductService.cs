using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int Create(ProductBLL item)
        {
            int id = productRepository.Create(mapper.Map<Product>(item));
            if (id != 0)
                return id;
            else
                return 0;
        }

        public IEnumerable<ProductBLL> GetFiltered(ProductQueryBLL query)
        {
            var prods = productRepository.GetSeveral(mapper.Map<ProductQuery>(query));
            var prodsBll = mapper.Map<List<ProductBLL>>(prods);
            return prodsBll;
        }

        public ProductBLL Find(int id)
        {
            var product = productRepository.GetById(id);
            if (product != null)
            {
                return mapper.Map<ProductBLL>(product);
            }
            else
            {
                return new ProductBLL();
            }
        }

        public void Update(ProductBLL productBll)
        {
            Product p = mapper.Map<Product>(productBll);
            productRepository.Update(p);
        }

        public void Delete(int id)
        {
            productRepository.DeleteById(id);
        }
    }
}
