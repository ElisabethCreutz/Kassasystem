using Kassasystem1.Purchase;
using System.Text.RegularExpressions;

namespace Kassasystem1.UserInput
{
    public class PurchaseInputControl
    {
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