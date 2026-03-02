namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static List<Product> mainProductList = new(); //skapar en huvudlista?? Behövs den ens?
        public static void ShowProductList()
        {
            ProductFileReader.ConvertProductFileToProductList();
            foreach (Product item in mainProductList)
            {
                Console.WriteLine($"{item.ProductId}: {item.ProductName} kostar {item.ProductPrice} per {item.ProductPriceType}");
            }
        }
        public static void FindProductInMainProductList() 
        {
            //söker upp en produkt i appens lista av produkter
            //ProductWriter.mainProductList
        }
        


    }
}