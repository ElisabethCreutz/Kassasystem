namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static List<Product> mainProductList = new(); 
        public static void ShowProductList()
        {
            //ProductFileReader.ConvertProductFileToProductList();
            foreach (Product item in mainProductList)
            {
                Console.WriteLine($"ID {item.ProductId}: {item.ProductName} kostar {item.ProductPrice} per {item.ProductPriceType}");
            }
            Console.ReadKey();
        }
        public static void FindProductInMainProductList() 
        {
            //söker upp en produkt i appens lista av produkter
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