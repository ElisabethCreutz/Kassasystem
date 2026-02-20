using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Kassasystem1.Products
{
    internal class ProductWriter
    {
        public static List<Product> mainProductList = new(); //skapar en huvudlista?? Behövs den ens?
        public static List<string> productsAsStrings = new();//skapar stränglistan
        public static string filepathProductList = "../../../Documents/ProductList/ProductList.txt";
        public static void ReadProductStringsFromFile()
        {
            var allLines = File.ReadAllLines(filepathProductList);
            foreach (var line in allLines)
            {
                productsAsStrings.Add(line);
            }
            Console.ReadKey();
        }
        public static void ConvertStringsToProductList(List<string> tempString)
        {
                  foreach (var line in tempString)
            {
                
                //lista ut något bra
                
            }  

        }
        //Nedan metod borde kunna vara non-static och kopplad till mainProductList!
        public static List<string> ConvertProductListToString(List<Product> temporaryProductList)
        {
            List<string> stringList = new();
            foreach (Product item in temporaryProductList)
            {
                string itemStr = ($"{item.ProductId}; {item.ProductName}; {item.ProductPrice}; {item.ProductPriceType}");
                stringList.Add(itemStr);
            }
            return stringList;
        }
        public static void WriteProductStringListToFile(List<string> stringList)
        {
            File.AppendAllLines(filepathProductList, stringList);//kraschar för att filen inte finns
        }

        public static void WriteTest2()
        {

            //innehåller bara testmetod
            FileStream productFileStream = File.OpenWrite(ProductWriter.filepathProductList);
            StreamWriter productStreamWriter = new StreamWriter(productFileStream);

            productStreamWriter.Close();
        }

        //om jag vill att den kollar att filen finns innan, annars fylla på data
        public static void CheckProductFile()
        {
            if (File.Exists("../../../Documents/Productlist/Productlist.txt")) return;

            string text = "10; Bananer; 29,90; kg\n" +
                          "20; Mjölk; 15,50; st\n";
            File.WriteAllText("../../../Documents/Productlist/Productlist.txt", text);
        }

    }
}
