using ShopBridge.Base;
using ShopBridge.Base.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.WebApp.Models
{
    public class ProductViewModel
    {
        public List<ProductViewData> ProductInformationList { get; set; } = new List<ProductViewData>();
        public ProductViewData ProductInfoData { get; set; } = new ProductViewData();

        public class ProductViewData
        {
            public int ProductId { get; set; } = 0;

            [Required(AllowEmptyStrings = false)]
            [Display(Name = "Product Name")]
            public string Name { get; set; } = string.Empty;
            
            [Display(Name = "Product Description")]
            public string Description { get; set; } = string.Empty;
            
            [Required(AllowEmptyStrings =false)]
            public int Quantity { get; set; } = 0;
            
            [Display(Name = "Unit")]
            public MeasurementUnit BaseUnit { get; set; }
            
            [Display(Name = "Status")]
            public ProductStatus ProductStatus { get; set; }
            
            [Required(AllowEmptyStrings = false)]
            [Display(Name = "MRP Rate")]
            public decimal MRPRate { get; set; } = 0;
            
            [Required(AllowEmptyStrings = false)]
            [Display(Name = "Selling Price")]
            public decimal SellingPrice { get; set; } = 0;
            
            public DateTime CreatedDateTime { get; set; }


            public ProductViewData BuildProductInformation(Product product_Info)
            {
                ProductId = product_Info.Id;
                Name = product_Info.Name;
                Description = product_Info.Description ?? string.Empty;
                Quantity = product_Info.Quantity;
                BaseUnit = product_Info.BaseUnit;
                ProductStatus = product_Info.ProductStatus;
                MRPRate = product_Info.MRPRate;
                SellingPrice = product_Info.SellingPrice;
                CreatedDateTime = product_Info.CreatedTime;

                return this;
            }

            public Product BuildProductInfoStorage(Product product_Info)
            {
                product_Info.Id = ProductId;
                product_Info.Name = Name;
                product_Info.Description = Description;
                product_Info.Quantity = Quantity;
                product_Info.BaseUnit = BaseUnit;
                product_Info.ProductStatus = ProductStatus;
                product_Info.MRPRate = MRPRate;
                product_Info.SellingPrice = SellingPrice;
                product_Info.CreatedTime = CreatedDateTime;

                return product_Info;
            }
        }
    }
}
