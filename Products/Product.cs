using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class Product
    {
        //Basic
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ProductPriceType { get; set; } = string.Empty;
        //avancerat
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; } = string.Empty;
        public string ProductCategoryPriceType { get; set; } = string.Empty;

        public Product(int productId, string productName, decimal price, string productPriceType)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = price;
            ProductPriceType = productPriceType;
        }
        public Product(int productId, string productName, decimal price, string productPriceType, int productCategoryId, string productCategoryName, string productCategoryPriceType)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = price;
            ProductPriceType = productPriceType;
            ProductCategoryId = productCategoryId;
            ProductCategoryName = productCategoryName;
            ProductCategoryPriceType = productCategoryPriceType;
        }
    }
}
