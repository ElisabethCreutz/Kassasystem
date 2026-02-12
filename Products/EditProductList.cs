using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class EditProductList
    {
        public string filepathProd = "../../../Documents/ProductList/ProductList.csv";
        public void CreateProductList() { 
        var allLines = File.ReadAllLines(filepathProd);
            foreach (var line in allLines)
                Console.WriteLine(line);
        }
        public void AddProduct(/*number of products, userinput*/)//kan man ha den flexibel i samma? overload?
        { 
        Product[] addProductArray= new Product[1];//creates an array that adds the number of products in []
            addProductArray[0]= new Product(100, "Mjölk",19.50m,"styck"); //skapa metod i annan klass som ger en userinput
            
            File.AppendAllLines(filepathProd,addProductArray);
        }
        public void EditProducts()
        { 
        FileStream productFileStream=File.OpenWrite(filepathProd);
            StreamWriter productStreamWriter=new StreamWriter(productFileStream);
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
