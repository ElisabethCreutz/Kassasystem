using Kassasystem1.Purchase;

namespace Kassasystem1.Receipt
{
    public interface IReceipt
    {
        public static string _receiptDate;
        public static string _receiptFilePath;
        private static bool _fileExists;
        private static decimal _sum;
        private static int _receiptNo;
        static void CheckReceiptFile() { }
        static void Write(List<PurchaseItem> purchaseItems) { }
        static int GetRecentReceiptNo()
        {
            return 0;
        }
    }
}
