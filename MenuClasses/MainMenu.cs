using Kassasystem1.PreviousOrTesting;
using Kassasystem1.Products;
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
            bool runningStore = true;
            while (runningStore)
            {
                string prompt = "Välkommen till Gamla Bettans matbutik";
                string[] options = { "Genomför köp", "Visa produktlistan", "Redigera produktlistan", "Ändra kampanjer", "Avsluta" };
                MenuStrategy mainMenu = new MenuStrategy(prompt, options);
                int userChoice = mainMenu.RunMenu();

                switch (userChoice)
                {
                    case 0:
                        Purchasing.NewPurchase();
                        break;
                    case 1:
                        ProductDisplay.ShowProductList();
                        Console.ReadKey();
                        break;
                    case 2:
                        MenuForProducts.RunEditProductsMenu();
                        break;
                    case 3:
                        MiscClass.FeatureDoesNotExist();
                        break;
                    case 4:
                        runningStore = false;
                        break;
                }
            }
        }
    }
}
