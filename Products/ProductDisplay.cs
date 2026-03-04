using System.Net.Http.Headers;

namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static List<Product> mainProductList = new();
        public static void ShowProductList()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gamla Bettans nya fräscha varor i butiken:");
            Console.ResetColor();
            foreach (Product item in mainProductList)
            {
                Console.WriteLine($"\tID {item.ProductId}: {item.ProductName} kostar {item.ProductPrice} per {item.ProductPriceType}");
            }
        }

        public static List<string> ConvertProductListToString()
        {
            List<string> stringList = new();
            foreach (Product item in mainProductList)
            {
                string itemStr = ($"{item.ProductId};{item.ProductName};{item.ProductPrice};{item.ProductPriceType}");
                stringList.Add(itemStr);
            }
            return stringList;
        }


    }
}