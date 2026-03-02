using Kassasystem1.MenuClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class EditProductList
    {
        public static void AddNewProduct()
        {
            
            string name = "";
            decimal price;
            string type;
            string answer;

            do
            {
                Console.Clear();
                name=ProductUserInputControl.CheckProductNameInput();
                price=ProductUserInputControl.CheckProductPriceInput();
                type=ProductUserInputControl.CheckProductTypeInput();
                Product newProduct = new Product(name, price, type);
                newProduct.ProductId = Product.GetRecentProductId() + 10;
                ProductDisplay.mainProductList.Add(newProduct);
                Console.Write("\nContinue? Yes or No: ");
                answer = Console.ReadLine().ToLower();
            }
            while (answer != "no");
           
            return;

        }
        public static Product FindAndSelectProduct()
        {
            Console.Clear();
            Product selectedProduct=null;
            //skriv ut filens strängar till en produktlista, välj vilken
            //produkt(plats i listan) som ska redigeras 
           
            return selectedProduct;
        }
        public static void EditProduct(Product product) {
            MenuProductPart.EditMenu();
        //redigera enbart vissa delar?
        }
        public static void DeleteProduct(Product product)
        {
            Console.Clear();

            //söker upp produktsträngen i en inläst string lista från filen för att välja
            //vilken rad som ska raderas
        }
    }
}
