using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Kassasystem1.Products
{
    internal class ProductFileReader
    {
        public static string filepathProductList = "../../../Documents/ProductList/ProductList.txt";
        public static void ConvertProductFileToProductList()
        {
            var allLines = File.ReadAllLines(filepathProductList);
            allLines.Sort();
            foreach (var line in allLines)
            {
                string[] columns = line.Split(';');
                int id = Convert.ToInt32(columns[0]);
                string name = columns[1];
                decimal price = Convert.ToDecimal(columns[2]);
                string description = columns[3];
                ProductDisplay.mainProductList.Add(new Product(id, name, price, description));
            }
        }
    }
}
