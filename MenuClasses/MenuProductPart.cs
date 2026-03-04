namespace Kassasystem1.MenuClasses
{
    internal class MenuProductPart
    {
        public static void EditMenu()
        {
            string prompt = "Vad vill du redigera?";
            string[] options = { "Produktnamn", "Pris", "Pristyp", "Tillbaka till huvudmenyn" };
            MenuStrategy prodMenu = new MenuStrategy(prompt, options);
            int userChoice = prodMenu.RunMenu();

            switch (userChoice)
            {
                case 0:
                    //Redigera produktnamn
                    break;
                case 1:
                    //redigera pris
                    break;
                case 2:
                    //redigera pristyp
                    break;
                case 3:
                    break;
            }


        }
    }
}
