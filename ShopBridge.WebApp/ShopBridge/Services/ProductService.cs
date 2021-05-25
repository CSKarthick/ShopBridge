using Microsoft.Extensions.Logging;
using ShopBridge.Base.Storage;
using ShopBridge.WebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShopBridge.WebApp.Models.ProductViewModel;

namespace ShopBridge.WebApp.Services
{
    public class ProductService : IProductService
    {
        public static string EmptyId = "Id cannot be empty";
        public static string DataNotFound = "No Data found";

        IProductRepository _productRepository;
        ILogger<ProductService> _logger;
        public ProductService(IProductRepository productRepository,
                            ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public Product GetProductInfo(int productId)
        {
            _logger.LogInformation("Entered into GetProductInfo method in product service");
            if (productId == 0) {
                _logger.LogError("Error occured in GetProductInfo method in product service where Id is 0");
                throw new Exception(EmptyId);
            }

            var productInfo = _productRepository.GetProduct(productId);

            if (productInfo == null) 
            {
                _logger.LogError("Error occured in GetProductInfo method in product service where collection is null");
                throw new Exception(DataNotFound); 
            }

            return productInfo;
        }

        public List<Product> GetAllProductList()
        {
            _logger.LogInformation("Entered into GetProductInfo method in product service");
            var productInfo = _productRepository.GetAllProductList();

            if (productInfo == null) {
                _logger.LogError("Error occured in SaveProduct method in product service");
                throw new Exception(DataNotFound); 
            }

            return productInfo;
        }

        public async Task<int> SaveProductInfo(ProductViewData productViewData) 
        {
            _logger.LogInformation("Entered into SaveProductInfo method in product service");
            var product = productViewData.BuildProductInfoStorage(new Product());
            var savedData = await SaveProduct(product);
            return savedData;
        }

        public async Task<int> SaveProduct(Product product)
        {
            _logger.LogInformation("Entered into SaveProduct method in product service");
            var returnValue = 0;
            if (product.Id == 0)
                returnValue = await _productRepository.AddProduct(product);

            if (product.Id != 0)
            {
                var productData = _productRepository.GetProduct(product.Id);
                if (productData == null)
                {
                    _logger.LogError("Error occured in SaveProduct method in product service");
                    throw new Exception(DataNotFound);
                }

                returnValue = await _productRepository.UpdateProduct(product);
            }
            return returnValue;
        }

        public async Task<int> DeleteProduct(int idToDelete)
        {
            _logger.LogInformation("Entered into DeleteProduct method in product service");
            var productData = GetProductInfo(idToDelete);
            var returnValue = await _productRepository.RemoveProduct(productData);
            return returnValue;
        }

        public List<ProductViewData> GetAllProductDataList()
        {
            _logger.LogInformation("Entered into GetAllProductDataList method in product service");
            var productInfoList = GetAllProductList();

            var productDataList = productInfoList.Select(x => new ProductViewData().BuildProductInformation(x)).ToList();

            return productDataList;
        }

        public ProductViewData GetProductData(int productId) 
        {
            _logger.LogInformation("Entered into GetProductData method in product service");
            var productInfoData = new ProductViewData();
            if (productId == 0)
                return productInfoData;

            var productData = GetProductInfo(productId);
            productInfoData = new ProductViewData().BuildProductInformation(productData);

            return productInfoData;
        }
    }
}
