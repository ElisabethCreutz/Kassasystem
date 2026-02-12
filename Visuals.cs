using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1
{
    internal class Visuals
    {
        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 /$$   /$$                                                 
| $$  /$$/                                                 
| $$ /$$/   /$$$$$$   /$$$$$$$ /$$$$$$$  /$$$$$$  /$$$$$$$ 
| $$$$$/   |____  $$ /$$_____//$$_____/ |____  $$| $$__  $$
| $$  $$    /$$$$$$$|  $$$$$$|  $$$$$$   /$$$$$$$| $$  \ $$
| $$\  $$  /$$__  $$ \____  $$\____  $$ /$$__  $$| $$  | $$
| $$ \  $$|  $$$$$$$ /$$$$$$$//$$$$$$$/|  $$$$$$$| $$  | $$
|__/  \__/ \_______/|_______/|_______/  \_______/|__/  |__/
");
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
