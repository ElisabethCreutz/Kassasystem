using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Purchase
{
    public class Purchasing
    {
        
        public List<Product> currentPurchase = new List<Product>();
        public void NewPurchase() 
        { 
            currentPurchase.Clear();
            //lägg till menu-loop?

            MenuForPurchase.PurchaseMenu();
            //Innehåller grundmetod: 
            //samt meny för lägg till produkt
        }
        public void AddPurchaseItem() 
        {
        //lägger till en 
        }   
        public void DeletePurchaseItem() { }
        public void EditPurchaseItem() { }
    }
}
