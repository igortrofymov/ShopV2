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
        private IProductService productService;
        private  IMapper mapper;

        public CategoriesController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ProductWEB>> GetAllProducts()
        {
        {
                IEnumerable<ProductBLL> products = productService.GetAll();
           return mapper.Map<List<ProductBLL>, List<ProductWEB>>(products.ToList());
        }
    }
}