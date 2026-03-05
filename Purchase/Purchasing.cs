using Kassasystem1.Actions;
using Kassasystem1.MenuClasses;
using Kassasystem1.Products;
using Kassasystem1.Receipt;

namespace Kassasystem1.Purchase
{
    public class Purchasing
    {
        public static List<PurchaseItem> currentPurchase = new();
        public static void NewPurchase()
        {
            Console.Clear();
            currentPurchase.Clear();
            bool buying = true;
            var id = 0;
            var amount = 0;
            while (id != 1)
            {
                Console.Clear();
                ProductDisplay.ShowProductList();
                Console.WriteLine("\nSkriv in produktid och antal varor du vill lägga till i köpet:\n");

                Purchaselist();
                do
                {
                    Console.WriteLine("\nSkriv in <ID> mellanslag <antal> eller skriv <PAY> för att betala");
                    string inputString = Console.ReadLine();
                    buying = UserInputControl.CheckPay(inputString);
                    if (buying)
                    {
                        buying = UserInputControl.CheckRegex(inputString);
                        if (buying)
                        {
                            List<int> values = UserInputControl.StringSeparation(inputString);
                            id = values[0];
                            amount = values[1];
                            if (amount == 0)
                            { amount++; }
                            id = UserInputControl.CheckProductID(id);
                            if (id!=0)
                            {
                                currentPurchase.Add(new PurchaseItem(id, amount));
                            }
                        }
                    }
                    else
                    {
                        id = 1;
                    }

                }
                while (id == 0);

            }

        }
        public static void CompletePurchase()
        {
            string userinput;
            Console.Clear();
            Visuals.Title();
            Purchaselist();
            do
            {
                Console.WriteLine("Vill du betala med kort eller kontant?");
                userinput = Console.ReadLine().ToLower();
            }
            while (userinput != "kort" && userinput != "kontant");
            if (userinput == "kort")
            {
                Console.Write("*Köpet behandlas");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine(".*");
                Thread.Sleep(1000);
                ReceiptTxt.Write(currentPurchase);
            }
            else
            {
                Console.Write("*Kassapersonalen räknar huvudräkning");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine(".*");
                Thread.Sleep(1000);
                ReceiptTxt.Write(currentPurchase);
            }
        }
        public static void CancelPurchase()
        {
            Console.WriteLine("Köpet har avbrutits");
            MainMenu.RunMainMenu();
        }
        public static void Purchaselist()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Varor i köpet:");
            Console.ResetColor();
            decimal sum = 0m;
            foreach (var item in currentPurchase)
            {
                Console.WriteLine($"\t{item.Name}; {item.Price} kr *{item.NumberOfItem} {item.PriceType} = {item.Price * item.NumberOfItem} kr");
                sum = sum + (item.Price * item.NumberOfItem);
            }
            Console.WriteLine($"\nTotalsumma är just nu: {sum} kr");
        }
    }
}
