using Kassasystem1.FileIO;
using Kassasystem1.MenuClasses;
using Kassasystem1.Receipt;

namespace Kassasystem1
{
    internal class RunProgram
    {
        public static void SetupStore()
        {
            WriteToProductFile.CheckProductFile();
            Visuals.Intro();
            Console.Clear();
            MainMenu.RunMainMenu();

            Console.Clear();
            Console.WriteLine("Tack för besöket och välkommen åter!");
            Thread.Sleep(2000);
        }
    }
}
