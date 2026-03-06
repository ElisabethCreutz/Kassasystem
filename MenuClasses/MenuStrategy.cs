using Kassasystem1.MainProgram;

namespace Kassasystem1.MenuClasses
{
    public class MenuStrategy
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        public MenuStrategy(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        private void DisplayOptions()
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
        public int RunMenu()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                Visuals.Title();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) { SelectedIndex = Options.Length - 1; }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) { SelectedIndex = 0; }
                }
            }
            while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}