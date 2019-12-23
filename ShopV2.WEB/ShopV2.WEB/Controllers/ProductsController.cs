using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.BLL;
using Core.WEB;
using Microsoft.AspNetCore.Mvc;
using ShopV2.BLL.Interfaces;

namespace ShopV2.WEB.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IProductService productService;

        public ProductsController(IProductService service, IMapper mapper)
        {
            productService = service;
            this.mapper = mapper;
        }

        [HttpPost]
        public int Create(ProductWEB productWeb)
        {
            return productService.Create(mapper.Map<ProductBLL>(productWeb));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductWEB>> GetAllProducts()
        {
            //var products = productService.GetAll();
            ProductFilterWEB f = new ProductFilterWEB();
            f.CatId = 17;
            ProductFilterBLL ff = mapper.Map<ProductFilterWEB,ProductFilterBLL>(f);
            var products = productService.GetSome(ff);
            return mapper.Map<List<ProductBLL>, List<ProductWEB>>(products.ToList());
        }
    }
}