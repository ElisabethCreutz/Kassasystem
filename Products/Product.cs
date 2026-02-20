using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class Product
    {
        public static int TotalProductId = 0;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ProductPriceType { get; set; } = string.Empty;

        public Product(string productName, decimal price, string productPriceType)
        {
            ProductId = TotalProductId + 10;
            ProductName = productName;
            ProductPrice = price;
            ProductPriceType = productPriceType;

        }
        public static int GetRecentProductId()
        {
            //hämta lista från filen 
            //plocka ut första siffrorna innan ", "
            //de högsta är TotalproductId
            return TotalProductId;
        }



    }
}
