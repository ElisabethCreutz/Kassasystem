using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static void ShowProductList() {
            foreach (Product item in Product.productList) {
                Console.WriteLine($"{item.ProductId}: {item.ProductName} kostar {item.ProductPrice} per {item.ProductPriceType}");
                        }
    }
}
