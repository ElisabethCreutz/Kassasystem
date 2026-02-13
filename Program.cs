using Kassasystem1.MenuClasses;
using System.ComponentModel.Design;

namespace Kassasystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visuals.Colors();
            Visuals.Intro();
            Console.ReadKey(true);
            Visuals.Title();
            MainMenu.RunMainMenu();
            //innehåller bara länk till menyn
            //InteractiveMenu.RunMenu();
            //NewInteractiveMenu.RunNewMenu();
            
        }
    }
}

