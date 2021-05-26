using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Base
{
    public enum MeasurementUnit
    {
        Piece = 1,
        Kilogram = 2,
        Litre = 3
    }

    public enum ProductStatus
    {
        Instock = 1,
        Sold = 2,
        OutOfStock = 3,
        Received = 4
    }
}
