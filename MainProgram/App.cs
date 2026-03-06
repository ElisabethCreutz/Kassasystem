using Kassasystem1.FileIO;
using Kassasystem1.MenuClasses;

namespace Kassasystem1.MainProgram
{
    public class App
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