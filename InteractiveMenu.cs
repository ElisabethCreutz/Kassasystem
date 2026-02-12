using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1
{
    public class InteractiveMenu
    {
        public static void RunMenu()
        {
            Console.Clear();
            Console.WriteLine("Kassan är öppen! Välj med pilarna och tryck enter");
            ConsoleKeyInfo key;
            bool isSelected = false;
            int option = 1;
            (int left, int top) = Console.GetCursorPosition();
            string selectColour = "\u001b[32m";
            string resetColour = "\u001b[0m";
            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(option == 1 ? selectColour : "")}Genomför köp{resetColour}");
                Console.WriteLine($"{(option == 2 ? selectColour : "")}Redigera produktlistan{resetColour}");
                Console.WriteLine($"{(option == 3 ? selectColour : "")}Lägg till kassör{resetColour}");
                Console.WriteLine($"{(option == 4 ? selectColour : "")}Ändra kampanjer{resetColour}");
                Console.WriteLine($"{(option == 5 ? selectColour : "")}Avsluta{resetColour}");

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 5 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 5 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
                
            }
            Console.WriteLine("Du valde x");

            Console.CursorVisible = true;
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        ProductDisplay.ShowProductList();
                        break;
                }

               if (option == 2) { ProductDisplay.ShowProductList(); }//skriver ut programmet direkt, utan att valet gjorts
            
            
        }
    }
}

