using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Receipt
{
    public interface IReceipt
    {
        public static string ReceiptDate = DateTime.Now.ToShortDateString();
        public static string receiptFilePath = $"../../../Documents/ReceiptFiles/Kvitto{ReceiptDate}.txt";
        private static bool fileExists;
        private static decimal sum;
        private static int ReceiptNo = 0;
        static void CheckReceiptFile() { }
        static void Write(List<PurchaseItem> purchaseItems) { }
        static int GetRecentReceiptNo()
        {
            return 0;
        }
    }
}
