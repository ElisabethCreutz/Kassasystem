using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Kassasystem1.Products
{
    internal class ProductUserInputControl
    {
        public static string CheckProductNameInput()
        {
            string name;
            do
            {
                Console.Write("Ange produktnamn: ");
                name = Console.ReadLine();
                Regex.Replace(name, @"[^\w\.@-]", ""); //TODO: fixa ;
            }
            while (name == "");
            return name;
                    }
        public static decimal CheckProductPriceInput()
        {
            decimal price = 0;
            do
            {
                Console.Write("Ange pris: ");
                //int price = decimal.Parse(Console.ReadLine()); //jämför felsökning med annan version
                var userPrice = Console.ReadLine();
                try
                {
                    price = Convert.ToDecimal(userPrice);
                }
                catch
                {
                    Console.WriteLine("The price is not entered in a correct way, please try again.");
                }
            }
            while (price <= 0);
            return price;
        }

        public static string CheckProductTypeInput()
        {
            string type;
            do
            {
                Console.Write("Är priset per kg eller per st? ");
                type = Console.ReadLine().ToLower();
            }
            while (type != "kg" && type != "st");
            return type;
        }
    }
}