using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class MainMenu
    {
        public static void RunMainMenu()
        {

            string prompt = "Välkommen till Gamla Bettans matbutik";
            string[] options = { "Genomför köp", "Redigera produktlistan", "Lägg till kassör", "Ändra kampanjer", "Avsluta" };
            Menu mainMenu = new Menu(prompt, options);
            int userChoice = mainMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    Purchasing.NewPurchase();
                    break;
                case 1:
                    MenuForProducts.RunEditProductsMenu();
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
