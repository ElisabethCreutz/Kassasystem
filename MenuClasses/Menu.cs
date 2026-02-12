using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.MenuClasses
{
    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string colour;
                if (i == SelectedIndex)
                {
                    colour = "\u001b[32m";
                }
                else
                {
                    colour = "";
                }
                Console.WriteLine($"{colour}>> {currentOption} <<\u001b[0m");
            }
        }
    }
}
