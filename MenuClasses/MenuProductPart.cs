
using Kassasystem1.Products;

namespace Kassasystem1.MenuClasses
{
    internal class MenuProductPart
    {
        public static void EditMenu(Product product)
        {
            string prompt = "Vad vill du redigera?";
            string[] options = { "Produktnamn", "Pris", "Pristyp", "Tillbaka till huvudmenyn" };
            MenuStrategy prodMenu = new MenuStrategy(prompt, options);
            int userChoice = prodMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    Console.WriteLine($"Nuvarande namn är: {product.ProductName}.");
                    var newName = ProductUserInputControl.CheckProductNameInput();
                    product.ProductName = newName;
                    Console.WriteLine($"Namnet har ändrats till: {product.ProductName}.");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine($"Nuvarande pris är: {product.ProductPrice}.");
                    var newPrice=ProductUserInputControl.CheckProductPriceInput();
                    product.ProductPrice = newPrice;
                    Console.WriteLine($"Det nya priset är (tostring) {product.ProductPrice.ToString()} kr");

                    Console.WriteLine($"Det nya priset är (endast dec) {product.ProductPrice} kr");
                    break;
                case 2:
                    Console.WriteLine($"Nuvarande pristyp är: {product.ProductPriceType}. Ange ny typ:");
                    var newType=ProductUserInputControl.CheckProductTypeInput();
                    product.ProductPriceType = newType;
                    Console.WriteLine($"Den nya pristypen är {product.ProductPriceType}.");
                    
                    break;
                case 3:
                    break;
            }


        }
    }
}
