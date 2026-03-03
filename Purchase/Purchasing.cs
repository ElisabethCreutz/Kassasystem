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
        // todo: skapa en ny klass med ny info 
        //konvertera Product till Purchaseitem och gör om allt.
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
            Console.WriteLine("\nSkriv in produktid och antal varor du vill lägga till i köpet: \n");
            //if (currentPurchase.Count != 0) {
            Console.Write("Varuid: ");
            var id = ProductUserInputControl.CheckIntInput();
            IDsorting.FindProductID(id);
            IDsorting.GetProductFromId(id);
            currentPurchase.Add(IDsorting.SelectedProduct);



            //todo: lägger till en Produkt i currentPurchase
            //Här finns två kommandon:
            //< produktid > < antal > ex 300 1, betyder lägg till en av produktid
            //PAY = vi ”fejkar” att det betalas och kvittot sparas ned(se nedan) och vi kommer tillbaka till menyn
        }
        public static void CompletePurchase() { }//todo PAY
        public static void CancelPurchase()
        {
            Console.WriteLine("Köpet har avbrutits");
            MainMenu.RunMainMenu();
        }
        public static void Purchaselist()
        {
            foreach (var item in currentPurchase)
            {
                Console.WriteLine($"{item.ProductName};{item.ProductPrice}* {item.ProductPriceType}");

            }
        }
    }
}
