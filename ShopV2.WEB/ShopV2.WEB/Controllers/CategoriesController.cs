using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopV2.BLL.DTO;
using ShopV2.BLL.Interfaces;

namespace ShopV2.WEB.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private IProductService productService;

        public CategoriesController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAllProducts()
        {
            IEnumerable<ProductDTO> products = productService.GetAll();
            return products.ToList();
        }
    }
}