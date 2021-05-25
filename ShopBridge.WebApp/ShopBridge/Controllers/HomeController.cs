using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopBridge.Models;
using ShopBridge.WebApp.Interfaces;
using ShopBridge.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static ShopBridge.WebApp.Models.ProductViewModel;

namespace ShopBridge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IProductService _iProductService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _iProductService = productService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Entered into Index method in home controller");
            var productInfoList = _iProductService.GetAllProductDataList();

            var productViewModel = new ProductViewModel
            {
                ProductInformationList = productInfoList
            };

            return View(productViewModel);
        }

        public IActionResult ProductEditor(int productId = 0) 
        {
            _logger.LogInformation("Entered into SaveProduct method in home controller");
            var productData = _iProductService.GetProductData(productId);
            var productViewModel = new ProductViewModel
            {
                ProductInfoData = productData
            };
            ViewData["Title"] = productId == 0 ? "Add Product" : "Edit Product";
            return PartialView(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductViewModel productViewModel) 
        {
            _logger.LogInformation("Entered into SaveProduct method in home controller");
            if (ModelState.IsValid == false) 
            {
                return BadRequest();
            }
            if (productViewModel == null) 
            {
                return NoContent();
            }

            var returnData = await _iProductService.SaveProductInfo(productViewModel.ProductInfoData);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int idToDelete) 
        {
            _logger.LogInformation("Entered into DeleteProduct method in home controller");
            if (idToDelete == null) 
            {
                return NoContent();
            }

            _iProductService.DeleteProduct(idToDelete);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
