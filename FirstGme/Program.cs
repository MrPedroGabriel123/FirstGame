﻿namespace FirstGme
{
    internal static class Game
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
                var userFirstChoice = Console.ReadLine();


                switch (userFirstChoice)
                {
                    case "Welcome":
                        Console.WriteLine("Choose one of the 3 options bellow");
                        break;
                    case "Start new game":
                        Console.WriteLine("Your game will start soon...");
                        Console.ReadLine();

                        Console.WriteLine("??? :Oh, you woke up, what is your name?");
                        var name = Console.ReadLine();
                        Console.WriteLine($"Jeff:Hi {name}, my name is Jeff and you are in our bunker right now");
                        Console.ReadLine();
                        Console.WriteLine($"{name}: What happend here? Why are we in a bunker?");
                        Console.ReadLine();
                        Console.WriteLine("Jeff: Russia is attacking us ");
                        Console.ReadLine();
                        Console.WriteLine($"{name}: But why? Why are they attacking us? That doesnt make any sense!");
                        Console.ReadLine();
                        Console.WriteLine($"Jeff: We dont know yet, we are still finding more people to create a group agaisnt russia");
                        Console.WriteLine($"Jeff: We need to help to figure it out whats going on, can you help us?");//This part will be when the player needs to choose between 2 story lines
                        Console.WriteLine("yes");
                        Console.WriteLine("no");
                        Console.ReadLine();
                        var userfirstchoice = Console.Read();//idk whats going on here
                        if (string.IsNullOrEmpty(userfirstchoice))
                        {
                            Console.WriteLine("you need to choose yes or no");
                            Console.ReadLine();
                            continue;
                        }
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        break;





                    case "Credits":
                        Console.WriteLine("Made by MrPedroGabriel123");
                        Console.WriteLine("MrAmos and Thalos helped my when I was stuck with any type of code");
                        Console.ReadLine();
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }








            }
            
        }
    }
}
