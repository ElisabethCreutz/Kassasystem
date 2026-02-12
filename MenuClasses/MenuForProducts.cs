using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class MenuForProducts
    {
        public static void RunEditProductsMenu()
        {


            string prompt = "Här kan du redigera produktlistan";
            string[] options = { "Visa produktlistan", "Lägg till ny produkt", "Ta bort produkt", "Ändra befintlig produkt", "Tillbaka till huvudmenyn" };
            Menu mainMenu = new Menu(prompt, options);
            int userChoice = mainMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    ProductDisplay.ShowProductList();
                    break;
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine("Feature will be added soon...");
                    break;
                case 3:
                    Console.WriteLine("Feature will be added soon...");
                    break;
                case 4:
                    Console.WriteLine("Feature will be added soon...");
                    break;
                case 5:
                    Menu.ExitGame();
                    break;

            }

        }

    }
}

