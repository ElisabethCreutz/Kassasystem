using Kassasystem1.MenuClasses;
using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1
{
    internal class RunProgram
    {
        public static void SetupStore()
        {
            ProductFileReader.CheckProductFile();
            Visuals.Intro();

            Visuals.Title();
            MainMenu.RunMainMenu();

            Console.Clear();
            Console.WriteLine("Tack för besöket och välkommen åter!");
            Thread.Sleep(2000);
        }
    }
}
