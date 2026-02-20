namespace Kassasystem1.Products
{
    public class ProductDisplay
    {
        public static void ShowProductList()//tänk om tänk rätt
        {
            foreach (Product item in ProductWriter.mainProductList)
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