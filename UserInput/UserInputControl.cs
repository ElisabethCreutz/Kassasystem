using Kassasystem1.Products;
using System.Text.RegularExpressions;

namespace Kassasystem1.Actions
{
    internal class UserInputControl
    {
        public static string CheckProductNameInput()
        {
            string name;
            do
            {
                Console.Write("Ange produktnamn: ");
                name = Console.ReadLine();
                Regex reg = new Regex("[*'\",_#^@;]");
                name = reg.Replace(name, string.Empty);
                Regex reg1 = new Regex("[ ]{2,}");
                name = reg1.Replace(name, " ");
                name = name.Trim(' ');
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
                var userPrice = Console.ReadLine();
                try
                {
                    price = Convert.ToDecimal(userPrice);
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök igen.");
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
        public static int CheckProductID()
        {
            int id = CheckIntInput();

            Product testProduct = ProductDisplay.mainProductList.Find(item => item.ProductId.Equals(id));
            if (testProduct == null)
            {
                id = 0;
                Console.WriteLine("ProduktId finns inte, försök igen.");
            }
            else
            { id = testProduct.ProductId; }
            return id;
        }
        public static int CheckIntInput()
        {
            int number = 0;
            do
            {
                string userinput = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(userinput);
                }
                catch { Console.WriteLine("Något gick fel, försök igen."); }
            }
            while (number == 0);
            return number;
        }
    }
}
