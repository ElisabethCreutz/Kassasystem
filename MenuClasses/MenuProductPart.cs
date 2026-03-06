using Kassasystem1.Products;

namespace Kassasystem1.MenuClasses
{
    public class MenuProductPart
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
                    EditProductList.EditProductName(product);
                    break;
                case 1:
                    EditProductList.EditProductPrice(product);
                    break;
                case 2:
                    EditProductList.EditProductPriceType(product);
                    break;
                case 3:
                    break;
            }
        }
    }
}