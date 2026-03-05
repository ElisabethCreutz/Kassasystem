using Kassasystem1.Purchase;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Kassasystem1.Receipt
{
    internal class ReceiptTxt : IReceipt
    {
        public static string ReceiptDate = DateTime.Now.ToShortDateString().Replace("-", "");
        public static string _receiptFilePath = $"../../../Documents/ReceiptFiles/RECEIPT_{ReceiptDate}.txt";
        private static bool _fileExists = false;
        private static decimal _sum;
        private static int _receiptNo = 0;



        static int GetReceiptNo()
        {
            if (File.Exists(_receiptFilePath)) { _fileExists = true; }
            else { _fileExists = false; }

            if (_fileExists == false)
            { _receiptNo++; }
            else if (_fileExists == true)
            {
                //_receiptNo = GetRecentReceiptNo();
                _receiptNo++;
            }
            return _receiptNo;
        }
        public static void Write(List<PurchaseItem> purchaseItems)
        {

            GetReceiptNo();

            using (StreamWriter writing = new StreamWriter(_receiptFilePath, append: _fileExists))
            {
                writing.WriteLine($"\nGamla Bettans mataffär");
                writing.WriteLine(DateTime.Now.ToString());
                writing.WriteLine($"Kvittonummer: {_receiptNo}\n");

                foreach (PurchaseItem item in purchaseItems)
                {
                    writing.WriteLine($"\t{item.Name} {item.NumberOfItem} st à {item.Price} kr/{item.PriceType}= {item.Price * item.NumberOfItem} kr");
                    _sum = _sum + (item.Price * item.NumberOfItem);
                }
                writing.WriteLine($"\nTotalsumma: {_sum} kr");
                writing.WriteLine("\nTack för köpet och välkommen åter!\n ******************************");

                Console.WriteLine("\nKvittot skrivs ut, tack för köpet!");
                Console.ReadKey();
            }
        }
        public static int GetRecentReceiptNo()
        {
            var lines = File.ReadAllLines(_receiptFilePath);
            List<int> number = new();
            for (int index = 0; index < lines.Length; index++)
            {
                if (lines[index].Contains("Kvittonummer"))
                {
                    string word = "Kvittonummer: ";
                    int startingAt = lines[index].IndexOf(word) + word.Length;
                    string result = lines[index].Substring(startingAt);
                    int num = Convert.ToInt32(result);
                    number.Add(num);
                }
            }
            number.Sort();
            number.Reverse();
            return number[0];
        }
    }
}