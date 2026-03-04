using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    internal class WriteToProductFile
    {
        public static void WriteProductStringListToFile(List<string> stringList)
        {
            File.WriteAllLines(ProductFileReader.filepathProductList, stringList);
        }
        public static void CheckProductFile()
        {
            if (File.Exists("../../../Documents/Productlist/Productlist.txt"))
                ProductFileReader.ConvertProductFileToProductList();
            return;

            string text = "10; Bananer; 29,90; kg\n" +
                          "20; Mjölk; 15,50; st\n";
            File.WriteAllText("../../../Documents/Productlist/Productlist.txt", text);
        }
    }
}
