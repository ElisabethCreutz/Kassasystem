namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static void ShowProductList()
        {
            foreach (Product item in EditProductList.productList)
            {
                Console.WriteLine($"{item.ProductId}: {item.ProductName} kostar {item.ProductPrice} per {item.ProductPriceType}");
            }
        }
        public static List<string> ConvertProductListToString(List<Product> prodList)
        {
            List<string> stringList = new();
            foreach (Product item in prodList)
            {
                string itemStr = ($"{item.ProductId}, {item.ProductName}, {item.ProductPrice}, {item.ProductPriceType}");
                stringList.Add(itemStr);
            }
            return stringList;
        }
    }
}