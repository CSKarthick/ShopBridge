using ShopBridge.Base.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShopBridge.WebApp.Models.ProductViewModel;

namespace ShopBridge.WebApp.Interfaces
{
    public interface IProductService
    {
        Product GetProductInfo(int productId);
        List<Product> GetAllProductList();
        Task<int> SaveProductInfo(ProductViewData productViewData);
        Task<int> SaveProduct(Product product);
        Task<int> DeleteProduct(int idToDelete);
        List<ProductViewData> GetAllProductDataList();
        ProductViewData GetProductData(int productId);
    }
}
