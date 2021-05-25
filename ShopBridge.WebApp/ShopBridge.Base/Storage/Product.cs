using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Base.Storage
{
    public class Product : StorageBase<Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Id")]
        public MeasurementUnit BaseUnit { get; set; }
        [ForeignKey("Id")]
        public ProductStatus ProductStatus { get; set; }
        public decimal MRPRate { get; set; } = 0;
        public decimal SellingPrice { get; set; } = 0;

        public Product SetBaseForProductInfo(bool isNewUserProfile = false)
        {
            this.LastModifiedTime = DateTime.UtcNow;

            if (isNewUserProfile == false) { return this; }

            this.CreatedTime = DateTime.UtcNow;

            return this;
        }
    }
}
