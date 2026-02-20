using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class MenuForProducts
    {
        public static void RunEditProductsMenu()
        {
            string prompt = "Här kan du redigera produktlistan";
            string[] options = { "Visa produktlistan", "Lägg till ny produkt", "Ändra befintlig produkt", "Ta bort produkt", "Tillbaka till huvudmenyn" };
            Menu prodMenu = new Menu(prompt, options);
            int userChoice = prodMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    ProductDisplay.ShowProductList();
                    //EditProductList.PrintProductList();
                    break;
                case 1:
                    EditProductList.AddNewProduct();
                    break;
                case 2:
                    Product selectedProductToEdit = EditProductList.FindAndSelectProduct();
                    EditProductList.EditProduct(selectedProductToEdit);
                    break;
                case 3:
                    Product selectedProductToDelete = EditProductList.FindAndSelectProduct();
                    EditProductList.DeleteProduct(selectedProductToDelete);
                    break;
                case 4:
                    Console.WriteLine("Tillbaka till huvudmenyn");
                    break;

            }

        }

    }
}

