using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class MenuForPurchase
    {
        public static void RunPurchaseMenu()
        {
            string prompt = "Här genomför du köpet, välj med piltangenterna och tryck enter";
            string[] options = { "Lägg till vara i köpet", "Redigera varor i köpet", "Slutför köp-betalning", "Avbryt köp" };
            Menu buyMenu = new Menu(prompt, options);
            int userChoice = buyMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    Purchasing.AddPurchaseItem();
                    break;
                case 1:
                    Purchasing.EditPurchaseItem();
                    break;
                case 2:
                    Purchasing.CompletePurchase();
                    break;
                case 3:
                    Purchasing.CancelPurchase();
                    break;
            }
        }
    }
}

