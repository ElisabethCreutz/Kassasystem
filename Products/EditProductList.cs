using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class EditProductList
    {
        public static List<Product> productList = new(); //skapar en huvudlista??

        public static string filepathProductList = "../../../Documents/ProductList/ProductList.csv";
        public static void PrintProductList()
        {
            Console.Clear();
            var allLines = File.ReadAllLines(filepathProductList);
            foreach (var line in allLines)
            {
                Console.WriteLine(line);
            }

        }
        public static void AddNewProduct()
        {
            List<Product> addProductList = new();//creates a list that adds the product in <>
            Console.Clear();
            Console.Write("Vad heter produkten: ");
            string name = Console.ReadLine();
            Console.Write("Vad kostar den:");
            decimal price = decimal.Parse(Console.ReadLine()); //jämför felsökning med annan version
            Console.Write("Är priset per kg eller per st? ");//vill helst ha en menyval för det istället för skrift
            string type = Console.ReadLine();
            Product newProduct = new Product(name, price, type);
            addProductList.Add(newProduct);
            var stringList = ProductDisplay.ConvertProductListToString(addProductList);
            File.AppendAllLines(filepathProductList, stringList);//kraschar

        }
        public static void EditProducts()
        {
            Console.Clear();
            FileStream productFileStream = File.OpenWrite(filepathProductList);
            StreamWriter productStreamWriter = new StreamWriter(productFileStream);
            productStreamWriter.Write(3);
            productStreamWriter.Write(",");
            productStreamWriter.Write("Hello\n");
            productStreamWriter.Write(4);
            productStreamWriter.Write(",");
            productStreamWriter.Write("Hello2\n");
            productStreamWriter.Close();
        }
        public static void DeleteProduct()
        {
            Console.Clear();
        }
    }
}
