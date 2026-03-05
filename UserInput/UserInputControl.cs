using Kassasystem1.Products;
using Kassasystem1.Purchase;
using System.ComponentModel.Design;
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
        public static int CheckProductID(int idInput)
        {

            Product testProduct = ProductDisplay.mainProductList.Find(item => item.ProductId.Equals(idInput));
            if (testProduct == null)
            {
                idInput = 0;
                Console.WriteLine("ProduktId finns inte, försök igen.");
            }
            else
            { idInput = testProduct.ProductId; }
            return idInput;
        }
        public static int CheckIntInput(string userInput)
        {
            int number = 0;

            try
            {
                number = Convert.ToInt32(userInput);
            }
            catch { Console.WriteLine("Något gick fel, försök igen."); }

            return number;
        }
        public static List<int> StringSeparation(string input)
        {
            List<int> values = new List<int>();


            string[] inputParts = input.Split(' ');

            foreach (string s in inputParts)
            {
                try
                {
                    s.Trim();
                    var x = Convert.ToInt32(s);
                    values.Add(x);
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök igen.");
                }
            }

            return values;

        }
        public static bool CheckPay(string input)
        {

            if (input.ToLower() == "pay")
            {
                if (Purchasing.currentPurchase.Count == 0)
                {
                    Console.WriteLine("Nu köper du ju ingenting men jag spelar med.");
                    Thread.Sleep(1000);
                }
                Purchasing.CompletePurchase();
                return false;

            }
            else
                return true;

        }
        public static bool CheckRegex(string input)
        {
            Regex stringReg = new Regex(@"^(\d+)\s+(\d+)$");
            Match? checkReg;

            checkReg = stringReg.Match(input);
            if (!checkReg.Success)
            {
                Console.WriteLine("Du skrev nog fel, försök igen.");
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}

