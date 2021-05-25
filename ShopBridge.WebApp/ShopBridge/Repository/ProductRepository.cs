using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopBridge.Base.Core;
using ShopBridge.Base.Storage;
using ShopBridge.WebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.WebApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        public DBConnectivity _dbConnectivity;
        public ILogger<ProductRepository> _logger;

        public ProductRepository(DBConnectivity dBConnectivity,
                                    ILogger<ProductRepository> logger)
        {
            _dbConnectivity = dBConnectivity;
            _logger = logger;
        }
        public Product GetProduct(int profileId)
        {
            var productInfo = _dbConnectivity.Product.AsNoTracking().FirstOrDefault(x => x.Id == profileId);
            return productInfo;
        }

        public List<Product> GetAllProductList()
        {
            var productInfo = _dbConnectivity.Product.ToList();
            return productInfo;
        }

        public async Task<int> AddProduct(Product product)
        {
            _dbConnectivity.Product.Add(product.SetBaseForProductInfo(true));

            return await _dbConnectivity.SaveChangesAsync();
        }

        public async Task<int> UpdateProduct(Product product)
        {
            product.SetBaseForProductInfo(false);
            _dbConnectivity.Product.Update(product);

            return await _dbConnectivity.SaveChangesAsync();
        }

        public async Task<int> RemoveProduct(Product product)
        {
           _dbConnectivity.Product.Remove(product);

            return await _dbConnectivity.SaveChangesAsync();
        }
    }
}
