using Kassasystem1.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Receipt
{
    public interface IReceipt
    {
        //public string ReceiptDate {  get; }
        void CheckReceiptFile();
        void Write(List<PurchaseItem> purchaseItems);
    }
}
