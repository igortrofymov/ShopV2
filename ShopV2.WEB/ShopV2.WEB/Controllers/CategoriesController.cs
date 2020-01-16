using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.BLL;
using Core.DAL;
using Core.WEB;
using Microsoft.AspNetCore.Mvc;
using ShopV2.BLL.Interfaces;

namespace ShopV2.WEB.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private ICategoryService catService;
        private IProductService productService;
        private IMapper mapper;

        public CategoriesController(IProductService productService, IMapper mapper, ICategoryService categoryService)
        {
            this.productService = productService;
            this.mapper = mapper;
            this.catService = categoryService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<CategoryWEB>> GetAllCategories()
        {
                IEnumerable<CategoryBLL> cats = catService.GetAll();
                return mapper.Map<List<CategoryWEB>>(cats.ToList());
        }

        [HttpPost]
        public int Create(ProductWEB productWeb)
        {
           return productService.Create(mapper.Map<ProductBLL>(productWeb));
        }
    }
}