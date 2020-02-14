﻿#define PROD1    // ProductsApiController use the same route so only one can be used.
using Microsoft.AspNetCore.Mvc;

namespace WebMvcRouting.Controllers
{
#if PROD1
    #region snippet1
    [ApiController]
    public class MyProductsController : ControllerBase
    {
        [HttpGet("/products3")]
        public IActionResult ListProducts() =>
            ControllerContext.ToActionResult();

        [HttpPost("/products3")]
        public IActionResult CreateProduct(MyProduct myProduct) =>
            ControllerContext.ToActionResult("", myProduct.Name);
    }
    #endregion

    public class MyProduct
    {
        public string Name { get; set; }
    }
#endif
}