using Kassasystem1.MenuClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

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
                name = ProductUserInputControl.CheckProductNameInput();
                price = ProductUserInputControl.CheckProductPriceInput();
                type = ProductUserInputControl.CheckProductTypeInput();
                Product newProduct = new Product(name, price, type);
                newProduct.ProductId = Product.SetLastUsedProductId() + 10;
                ProductDisplay.mainProductList.Add(newProduct);
                Console.Write("\nContinue? Yes or No: ");
                answer = Console.ReadLine().ToLower();
            }
            while (answer != "no");
            return;

        }
        public static Product FindAndSelectProduct()
        {
            ProductDisplay.ShowProductList();
            Console.WriteLine("\nSkriv produktId för produkten du vill ändra:");
            int userID = ProductUserInputControl.CheckProductID();
            Product selectedProduct = IDsorting.GetProductFromId(userID);
            return selectedProduct;
        }
        public static void EditProduct()
        {
            Console.Clear();
            MenuProductPart.EditMenu(FindAndSelectProduct());
        }
        public static void DeleteProduct()
        {
            Console.Clear();
           var productTodelete=FindAndSelectProduct();
            ProductDisplay.mainProductList.Remove(productTodelete);

            Console.WriteLine($"{productTodelete.ProductName} has been deleted.");

        }
    }
}
