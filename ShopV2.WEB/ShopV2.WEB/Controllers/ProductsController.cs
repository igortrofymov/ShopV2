using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public int Create([FromBody] ProductWEB productWeb)
        {
            return productService.Create(mapper.Map<ProductBLL>(productWeb));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductWEB>> GetAllProducts(ProductQueryWEB query)
        {
            var filterBll = mapper.Map<ProductQueryBLL>(query);
            var products = productService.GetFiltered(filterBll);
            return mapper.Map<List<ProductBLL>, List<ProductWEB>>(products.ToList());
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateProduct([FromBody] ProductWEB productWeb)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var prodBll = productService.Find((int)productWeb.ProductId);
            if (prodBll == null)
                return NotFound();
            productWeb.Created = DateTime.Now;
            mapper.Map<ProductWEB, ProductBLL>(productWeb, prodBll);
            productService.Update(prodBll);
            return Ok(productWeb);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (productService.Find(id) == null)
                return NotFound();
            productService.Delete(id);
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProd(int id)
        {
            var prodBll = productService.Find(id);
            if(prodBll.ProductId!=0)
            return Ok(mapper.Map<ProductWEB>(prodBll));
            else
            {
                return NotFound();
            }
        }
    }
}