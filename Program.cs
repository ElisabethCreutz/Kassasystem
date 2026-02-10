using System.ComponentModel.Design;

namespace Kassasystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Skriv en meny med flera val till program i programmet.
            Funktioner i menyn:
                1. Ta betalt
                2. Lägg till ny vara
                3. Avsluta
            Funktioner som lagras i kvittofil i 1:
                Visa lista över produkter
                Skapar nytt löpnummer
                Registrera datum och tid
                Registrera varor
                Räkna summan av varorna
                Räkna ut vad kunden ska ha tillbaka i kr
                Lagra i kvittofil där nya löpnummer läggs till efter varandra - ett nytt kvitto per dag!
                Räkna ut moms på kvittot - 6%?
            Funktioner filen ska lagra i 2:
            Skriv till fil: informationen om varor finns i en textfil, skrivs till och hämtas från filen!
                produktid
                produktnamn
                pris
                pris typ (kg/st)
            Grundläggande funktioner:
                Strängmanipulering! om man skriver in "5 300" ska den kunna hantera 5st av vara 300
                (dela upp strängen när det är mellanslag - 1 är antal och 2 är produktkod)
                (hur hantera max/min-värden av antal och produktkod? ex förvalt intervall för produktkoder?)
            Extra funktioner:
                Form/färg
                Menyval: registrera kassapersonal
                Kampanjpriser
                UML diagram
                


             */
            bool cont = true;
            while (cont)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("KASSAMENY");
                Console.WriteLine("1: Ta betalt");
                Console.WriteLine("2: Ändra varor");
                Console.WriteLine("4: Lägg till kassör");
                Console.WriteLine("3: Ändra kampanjer");
                Console.WriteLine("5: Avsluta");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    //program 1
                }


            }
        }
    }
}
