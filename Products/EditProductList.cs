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
            List<Product> temporaryProductList = new();//creates a list that adds the product in <>
            var key = ConsoleKey.Escape;
            string name = "";
            decimal price;
            string type;
            string answer;
            do
            {
                Console.Clear();
                Console.Write("Vad heter produkten: ");
                name = Console.ReadLine();
                Console.Write("Vad kostar den:");
                price = decimal.Parse(Console.ReadLine()); //jämför felsökning med annan version
                Console.Write("Är priset per kg eller per st? ");//vill helst ha en menyval för det istället för skrift
                type = Console.ReadLine();
                Product newProduct = new Product(name, price, type);
                newProduct.ProductId = Product.GetRecentProductId() + 10;
                temporaryProductList.Add(newProduct);
                Console.Write("\nContinue? Yes or No:");
                answer = Console.ReadLine().ToLower();
            }
            while (answer != "no");
            var stringList = ProductWriter.ConvertProductListToString(temporaryProductList);
            ProductWriter.WriteProductStringListToFile(stringList);
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
