using Kassasystem1.FileIO;
using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Receipt
{
    internal class ReceiptTxt
    {
        public static string ReceiptDate = DateTime.Now.ToShortDateString();
        public static string receiptFilePath = $"../../../Documents/ReceiptFiles/Kvitto{ReceiptDate}.txt";
        private static bool fileExists = false;
        private static decimal sum;
        private static int ReceiptNo = 0;

        static int GetReceiptNo()
        {
            CheckReceiptFile();
            if (fileExists == false)
            { ReceiptNo++; }
            else if (fileExists == true)
            {
                ReceiptNo = GetRecentReceiptNo();
                ReceiptNo++;
            }
            return ReceiptNo;
        }
        static void CheckReceiptFile()
        {
            if (File.Exists(receiptFilePath)) { fileExists = true; }
            else { fileExists = false; }
        }
        public static void Write(List<PurchaseItem> purchaseItems)
        {
            GetReceiptNo();
            CheckReceiptFile();

            using (StreamWriter writing = new StreamWriter(receiptFilePath, append: fileExists))
            {
                writing.WriteLine($"\nGamla Bettans mataffär");
                writing.WriteLine(DateTime.Now.ToString());
                writing.WriteLine($"Kvittonummer: {ReceiptNo}\n");
                
                foreach (PurchaseItem item in purchaseItems)
                {
                    writing.WriteLine($"\t{item.Name} {item.NumberOfItem} st à {item.Price} kr/{item.PriceType}= {item.Price * item.NumberOfItem} kr");
                    sum = sum + (item.Price * item.NumberOfItem);
                }
                writing.WriteLine($"\nTotalsumma: {sum} kr");
                writing.WriteLine("\nTack för köpet och välkommen åter!\n ******************************");

                Console.WriteLine("\nKvittot skrivs ut, tack för köpet!");
                Console.ReadKey();
            }
        }
        public static int GetRecentReceiptNo()
        {
            var lines = File.ReadAllLines(receiptFilePath);
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