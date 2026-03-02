using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    internal class WriteToProductFile
    {
        public static string filepathProductList2 = "../../../Documents/ProductList/ProductList.txt";

        
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
            File.AppendAllLines(filepathProductList2, stringList);
        }

        public static void WriteTest2()
        {

            //innehåller bara testmetod
            FileStream productFileStream = File.OpenWrite(ProductFileReader.filepathProductList);
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
