using ShopBridge.Base.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.WebApp.Interfaces
{
    public interface IProductRepository
    {
        Product GetProduct(int profileId);
        List<Product> GetAllProductList();
        Task<int> AddProduct(Product product);
        Task<int> UpdateProduct(Product product);
        Task<int> RemoveProduct(Product product);
    }
}
