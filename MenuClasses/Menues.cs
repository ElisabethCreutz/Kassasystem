using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class Menues
    {
        public static void RunMainMenu()
        {
            string prompt = "Välkommen till xx";
            string[] options = { "Genomför köp", "Redigera produktlistan", "Lägg till kassör", "Ändra kampanjer", "Avsluta" };
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.DisplayOptions();
        }
        public static void RunPurchaseMenu()
        {
            //allows cashier to choose between
            //"add Product to purchase items"
            //"remove item from Purchase"
            //"edit item in Purchase"
            //"press pay"
        }
        public static void RunEditProductsMenu() 
        {
        
        }
    }                            
}                              
                              