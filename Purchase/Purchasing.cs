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
            ProductDisplay.ShowProductList();
            Console.WriteLine("Skriv in produktid och antal varor du vill lägga till i köpet: ");
Console.ReadLine();
            //todo: lägger till en Produkt i currentPurchase
            //Här finns två kommandon:
            //< produktid > < antal > ex 300 1, betyder lägg till en av produktid
            //PAY = vi ”fejkar” att det betalas och kvittot sparas ned(se nedan) och vi kommer tillbaka till menyn
        }
        public static void EditPurchaseItem()
        {
            // todo: tryck blablabla för att komma till en EditPurchase-menu där du kan välja mellan
            // att redigera eller ta bort befintlig. Då omvandlas också listan till en array
            // som redigeras och sen skickar tillbaka en lista till currentPurchase-List<Products>
        }
        public static void DeleteItem() { }//todo
        public static void EditItem() { }//todo
        public static void CompletePurchase() { }//todo PAY
        public static void CancelPurchase()
        {
            Console.WriteLine("Köpet har avbrutits");
            MainMenu.RunMainMenu();
        }
    }
}
