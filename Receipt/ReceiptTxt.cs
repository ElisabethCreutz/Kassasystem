using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Receipt
{
    internal class ReceiptTxt:IReceipt
    {
        public string ReceiptDate=DateTime.Now.ToShortDateString();

        public string Extension => throw new NotImplementedException();

        public void CreateReceipt()
        {
            ReceiptDate= DateTime.Now.ToShortDateString();//välj den som gör datum och klockslag
            //Kassör
            string receiptFilePath = $"../../../Documents/ReceiptFiles/Kvitto{ReceiptDate}.csv";
            using (StreamWriter receiptStream = new StreamWriter($"../../../Documents/ReceiptFiles/Kvitto{ReceiptDate}.txt", append:false))
            {
                //Kalla på metod för köpet
                //metod som skriver ut varor, betalt och kvitto
                Console.WriteLine("Kvittot skrivs ut, tack för köpet");
            }
        }

        public void Write(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
