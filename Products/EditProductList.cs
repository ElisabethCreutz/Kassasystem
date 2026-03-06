using Kassasystem1.Actions;
using Kassasystem1.MainProgram;

namespace Kassasystem1.Products
{
    public class EditProductList
    {
        public static void AddNewProduct()
        {
            string name = "";
            decimal price;
            string type;
            string answer;
            do
            {
                Console.Clear();
                Visuals.Title();
                name = ProductInputControl.CheckProductNameInput();
                price = ProductInputControl.CheckProductPriceInput();
                type = ProductInputControl.CheckProductTypeInput();
                Product newProduct = new Product(name, price, type);
                newProduct.ProductId = Product.SetLastUsedProductId() + 10;
                ProductDisplay.mainProductList.Add(newProduct);
                Console.Write("\nContinue? Yes or No: ");
                answer = Console.ReadLine().ToLower();
            }
            while (answer != "no");
            return;
        }
        public static Product ProductSearch()
        {
            int userID;
            ProductDisplay.ShowProductList();
            do
            {
                Console.WriteLine("\nSkriv produktId för produkten du vill välja:");
                string userReply= Console.ReadLine();
                userID = ProductInputControl.CheckIntInput(userReply);
                userID= ProductInputControl.CheckProductID(userID);
            }
            while (userID == 0);
            Product selectedProduct = ProductIdHandler.GetProductFromId(userID);
            return selectedProduct;
        }
        public static void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("Radera en produkt i listan:\n");
            var productTodelete = ProductSearch();
            Console.WriteLine("Tryck <Enter> för att fortsätta eller <Escape> för att avbryta");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                return;
            }
            ProductDisplay.mainProductList.Remove(productTodelete);
            Console.WriteLine($"{productTodelete.ProductName} har raderats från produktlistan.");
            Console.ReadKey();
        }
        public static void EditProductName(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande namn är: {product.ProductName}.");
            var newName = ProductInputControl.CheckProductNameInput();
            product.ProductName = newName;
            Console.WriteLine($"Namnet har ändrats till: {product.ProductName}.");
            Console.ReadKey();
        }
        public static void EditProductPrice(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande pris är: {product.ProductPrice}.");
            var newPrice = ProductInputControl.CheckProductPriceInput();
            product.ProductPrice = newPrice;
            Console.WriteLine($"Det nya priset är {product.ProductPrice} kr");
            Console.ReadKey();
        }
        public static void EditProductPriceType(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande pristyp är: {product.ProductPriceType}. Ange ny typ:");
            var newType = ProductInputControl.CheckProductTypeInput();
            product.ProductPriceType = newType;
            Console.WriteLine($"Den nya pristypen är {product.ProductPriceType}.");
            Console.ReadKey();
        }
    }
}