using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{

    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [Route("api/products/gets")]
        public IList<Products> ProductsGetAll()
        {
            return _productsService.ProductsGetAll();
        }

  
        [HttpGet]
        [Route("api/products/get/{id}")]
        public Products ProductsGetById(int Id)
        {
            return _productsService.ProductsGetByID(Id);
        }


        [HttpPost]
        [Route("api/products/add")]
        public bool ProductsAdd([FromBody] ProductsAdd request)
        {
            return _productsService.ProductsAdd(request);
        }

        [HttpPut]
        [Route("api/products/update")]
        public bool ProductsUpdate([FromBody] ProductsUpdate request)
        {
            return _productsService.ProductsUpdate(request);
        }

        [HttpDelete]
        [Route("api/products/delete/{id}")]
        public bool ProductsDelete(int Id)
        {
            return _productsService.ProductsDelete(Id);
        }
    }
}
