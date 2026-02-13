using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class Product
    {
        public static int TotalProductId = 0;
        //Basic
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ProductPriceType { get; set; } = string.Empty;

        public Product(string productName, decimal price, string productPriceType)
        {
            ProductId = TotalProductId + 100;
            ProductName = productName;
            ProductPrice = price;
            ProductPriceType = productPriceType;

        }
        //public Product(string productName, decimal price, string productPriceType, int productCategoryId, string productCategoryName, string productCategoryPriceType)
        //{
        //    ProductId = TotalProductId + 100;
        //    ProductName = productName;
        //    ProductPrice = price;
        //    ProductPriceType = productPriceType;
        //    ProductCategoryId = productCategoryId;
        //    ProductCategoryName = productCategoryName;
        //    ProductCategoryPriceType = productCategoryPriceType;
        //}
        public static List<string> ProductsToString()
        {
            List<string> productToStringList = new();
            foreach (Product product in EditProductList.productList)
            {
                productToStringList.Add($"{product.ProductId}, {product.ProductName}, {product.ProductPrice}, {product.ProductPriceType}");
            }
            return productToStringList;
        }

    }
}
