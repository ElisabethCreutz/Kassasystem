using Kassasystem1.Products;

namespace Kassasystem1.MenuClasses
{
    public class MenuForProducts
    {
        public static void RunEditProductsMenu()
        {
            string prompt = "Här kan du redigera produktlistan";
            string[] options = { "Visa produktlistan", "Lägg till ny produkt", "Ändra befintlig produkt", "Ta bort produkt", "Tillbaka till huvudmenyn" };
            MenuStrategy prodMenu = new MenuStrategy(prompt, options);
            int userChoice = prodMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    ProductDisplay.ShowProductList();
                    Console.ReadKey();
                    break;
                case 1:
                    EditProductList.AddNewProduct();
                    break;
                case 2:
                    Console.Clear();
                    MenuProductPart.EditMenu(EditProductList.ProductSearch());
                    break;
                case 3:
                    EditProductList.DeleteProduct();
                    break;
                case 4:
                    Console.WriteLine("Tillbaka till huvudmenyn");
                    break;

            }

        }

    }
}

