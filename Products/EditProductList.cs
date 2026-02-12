using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class EditProductList
    {
        public string filepathProductList = "../../../Documents/ProductList/ProductList.csv";
        public void CreateProductList()
        {
            
            var allLines = File.ReadAllLines(filepathProductList);
            foreach (var line in allLines)
            {
                Console.WriteLine(line);
            }
          
        }
        public void AddNewProduct()
        {
            List<Product> addProductList = new ();//creates a list that adds the product in <>

            Console.Write("Vad heter produkten: ");
            string name = Console.ReadLine();
            Console.Write("Vad kostar den:");
            decimal price = decimal.Parse(Console.ReadLine()); //jämför felsökning med annan version
            Console.Write("Är priset per kg eller per st? ");//vill helst ha en menyval för det istället för skrift
            string type = Console.ReadLine();
            Product newProduct = new Product(name, price, type);
            addProductList.Add(newProduct);


            File.AppendAllLines(filepathProductList,addProductList);
        }
        public void EditProducts()
        {
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
        public void DeleteProduct() { }
    }
}
