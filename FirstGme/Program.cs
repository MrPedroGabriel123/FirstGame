﻿namespace Game
{
    internal static class game
    {
        public static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wecolme");
                Console.WriteLine("Start new game");
                Console.WriteLine("Credits");
                Console.WriteLine("Exit");
                var UserFirstChoice = Console.ReadLine();
                

               if (UserFirstChoice == string.Empty)
                {
                    Console.WriteLine("You need to choose something");
                    Console.ReadLine();
                    continue;
                }

                if (UserFirstChoice == "Wecolme")
                {
                    Console.WriteLine("Choose one of the 3 options bellow");
                    Console.ReadLine();
                    continue;
                }
                if (UserFirstChoice == "Start new game")
                {
                    Console.WriteLine("Your game will start soon...");
                    Console.ReadLine();

                    Console.WriteLine("??? :Oh, you woke up, what is your name?");
                    var name = Console.ReadLine();
                    Console.WriteLine($"Jeff:Hi {name}, my name is Jeff and you are in our bunker right now");
                    Console.ReadLine();
                    Console.WriteLine($" {name} : What happend here? Why are we in a bunker?");
                    Console.ReadLine();
                    Console.WriteLine("Jeff: Russia is attacking us ");
                    Console.ReadLine();

                }
                if (UserFirstChoice == "Credits")
                {
                    Console.WriteLine("Made by MrPedroGabriel123");
                    Console.WriteLine("MrAmos and Thalos helped my when I was stuck with any type of code");
                    Console.ReadLine();
                    continue;
                }
                if (UserFirstChoice == "Exit")
                {
                    System.Environment.Exit(0);
                }
            }
            
        }
    }
}
