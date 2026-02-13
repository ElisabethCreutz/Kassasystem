using Kassasystem1.MenuClasses;
using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Purchase
{
    public class Purchasing
    {
        public static List<Product> currentPurchase = new List<Product>();
        public static void NewPurchase()
        {
            currentPurchase.Clear();
           
            MenuForPurchase.RunPurchaseMenu();
            //Innehåller grundmetod: 
            //samt meny för lägg till produkt
        }
        public static void AddPurchaseItem()
        {
            //lägger till en Produkt i currentPurchase
        }
        public static void EditPurchaseItem()
        {
            // tryck blablabla för att komma till en EditPurchase-menu där du kan välja mellan
            // att redigera eller ta bort befintlig. Då omvandlas också listan till en array
            // som redigeras och sen skickar tillbaka en lista till currentPurchase-List<Products>
        }
        public static void DeleteItem() { }
        public static void EditItem() { }
        public static void CompletePurchase() { }
        public static void CancelPurchase() {
            Console.WriteLine("Köpet har avbrutits");
            MainMenu.RunMainMenu();
        }
    }
}
