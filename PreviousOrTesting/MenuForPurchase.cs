using Kassasystem1.MenuClasses;
using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.PreviousOrTesting
{
    internal class MenuForPurchase
    {
        public static void RunPurchaseMenu()
        {
            string prompt = "Här genomför du köpet, välj med piltangenterna och tryck enter";
            string[] options = { "Lägg till vara i köpet", "Slutför köp-betalning", "Avbryt köp" };
            MenuStrategy buyMenu = new MenuStrategy(prompt, options);
            int userChoice = buyMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    //Purchasing.AddPurchaseItem();
                    break;
                case 1:
                    Purchasing.CompletePurchase();
                    break;
                case 2:
                    Purchasing.CancelPurchase();
                    break;
            }
        }
    }
}

