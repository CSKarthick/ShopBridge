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
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductInfo(int productId)
        {
            if (productId == 0) { throw new Exception(EmptyId); }

            var productInfo = _productRepository.GetProduct(productId);

            if (productInfo == null) { throw new Exception(DataNotFound); }

            return productInfo;
        }

        public List<Product> GetAllProductList()
        {
            var productInfo = _productRepository.GetAllProductList();

            if (productInfo == null) { throw new Exception(DataNotFound); }

            return productInfo;
        }

        public async Task<int> SaveProductInfo(ProductViewData productViewData) 
        {
            var product = productViewData.BuildProductInfoStorage(new Product());
            var savedData = await SaveProduct(product);
            return savedData;
        }

        public async Task<int> SaveProduct(Product product)
        {
            var returnValue = 0;
            if (product.Id == 0)
                returnValue = await _productRepository.AddProduct(product);

            if (product.Id != 0)
            {
                var productData = _productRepository.GetProduct(product.Id);
                if (productData == null)
                    throw new Exception(DataNotFound);

                returnValue = await _productRepository.UpdateProduct(product);
            }
            return returnValue;
        }

        public async Task<int> DeleteProduct(int idToDelete)
        {
            var productData = GetProductInfo(idToDelete);
            var returnValue = await _productRepository.RemoveProduct(productData);
            return returnValue;
        }

        public List<ProductViewData> GetAllProductDataList()
        {
            var productInfoList = GetAllProductList();

            var productDataList = productInfoList.Select(x => new ProductViewData().BuildProductInformation(x)).ToList();

            return productDataList;
        }

        public ProductViewData GetProductData(int productId) 
        {
            var productInfoData = new ProductViewData();
            if (productId == 0)
                return productInfoData;

            var productData = GetProductInfo(productId);
            productInfoData = new ProductViewData().BuildProductInformation(productData);

            return productInfoData;
        }
    }
}
