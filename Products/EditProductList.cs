using Kassasystem1.Actions;

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
                name = UserInputControl.CheckProductNameInput();
                price = UserInputControl.CheckProductPriceInput();
                type = UserInputControl.CheckProductTypeInput();
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
                userID = UserInputControl.CheckIntInput(userReply);
                userID= UserInputControl.CheckProductID(userID);
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
            ProductDisplay.mainProductList.Remove(productTodelete);
            Console.WriteLine($"{productTodelete.ProductName} has been deleted.");
            Console.ReadKey();

        }
        public static void EditProductName(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande namn är: {product.ProductName}.");
            var newName = UserInputControl.CheckProductNameInput();
            product.ProductName = newName;
            Console.WriteLine($"Namnet har ändrats till: {product.ProductName}.");
            Console.ReadKey();
        }
        public static void EditProductPrice(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande pris är: {product.ProductPrice}.");
            var newPrice = UserInputControl.CheckProductPriceInput();
            product.ProductPrice = newPrice;
            Console.WriteLine($"Det nya priset är {product.ProductPrice} kr");
            Console.ReadKey();
        }
        public static void EditProductPriceType(Product product)
        {
            Console.Clear();
            Console.WriteLine($"Nuvarande pristyp är: {product.ProductPriceType}. Ange ny typ:");
            var newType = UserInputControl.CheckProductTypeInput();
            product.ProductPriceType = newType;
            Console.WriteLine($"Den nya pristypen är {product.ProductPriceType}.");
            Console.ReadKey();
        }
    }
}
