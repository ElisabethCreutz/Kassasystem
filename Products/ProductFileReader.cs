using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Kassasystem1.Products
{
    internal class ProductFileReader
    {

        // public static List<string> productsAsStrings = new();//skapar stränglistan
        public static string filepathProductList = "../../../Documents/ProductList/ProductList.txt";
        public static void ConvertProductFileToProductList()
        {
            var allLines = File.ReadAllLines(filepathProductList);
            foreach (var line in allLines)
            {
                //productsAsStrings.Add(line);
                string[] columns = line.Split(';');
                int id = Convert.ToInt32(columns[0]);
                decimal price = Convert.ToDecimal(columns[2]);
                ProductDisplay.mainProductList.Add(new Product(id, columns[1], price, columns[3]));
            }
        }
    }
}
