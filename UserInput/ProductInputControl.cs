using Kassasystem1.Products;
using System.Text.RegularExpressions;

namespace Kassasystem1.Actions
{
    public class ProductInputControl
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
        public static int CheckProductID(int idInput)
        {

            Product testProduct = ProductDisplay.mainProductList.Find(item => item.ProductId.Equals(idInput));
            if (testProduct == null)
            {
                idInput = 0;
                Console.WriteLine("ProduktId finns inte, försök igen.");
            }
            else
            {
                idInput = testProduct.ProductId;
            }
            return idInput;
        }
        public static int CheckIntInput(string userInput)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(userInput);
            }
            catch
            {
                Console.WriteLine("Något gick fel, försök igen.");
            }
            return number;
        }
    }
}