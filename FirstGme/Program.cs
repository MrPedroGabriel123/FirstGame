namespace FirstGme;

internal static class Game
{
    private static string Name { get; set; }

    public static void Main()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) Welcome");
            Console.WriteLine("2) Start new game");
            Console.WriteLine("3) Credits");
            Console.WriteLine("4) Exit");
            var userFirstChoice = "Enter choice".PromptInt(minValue: 1, maxValue: 4);

            var stringList = new List<string>
            {
                "??? :Oh, you woke up, what is your name?",
                $"Jeff:Hi {Name}, my name is Jeff and you are in our bunker right now",
                $"{Name}: What happend here? Why are we in a bunker?"
            };

            switch (userFirstChoice)
            {
                case 1:
                    Console.WriteLine("Choose one of the 3 options bellow");
                    break;
                case 2:
                    Console.WriteLine("Your game will start soon...");
                    Console.ReadKey();

                    Console.WriteLine(stringList[0]);
                    Name = Console.ReadLine() ?? "Jefferson";
                    Console.WriteLine(stringList[1]);


                    Console.ReadKey();
                    Console.WriteLine("Jeff: Russia is attacking us ");

                    Console.ReadKey();
                    Console.WriteLine(
                        $"{Name} But why? Why are they attacking us? That doesnt make any sense!");

                    Console.ReadKey();
                    Console.WriteLine(
                        "Jeff: We dont know yet, we are still finding more people to create a group agaisnt russia");

                    Console.WriteLine("Jeff: We need to help to figure it out whats going on, can you help us?");

                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");

                    var userSecondChoice = "Enter choice".PromptInt(minValue: 1, maxValue: 2);

                    switch (userSecondChoice)
                    {
                        case 1:
                            Console.WriteLine("Jeff: Thanks! We are happy to have a new member on our crew");
                            Console.WriteLine(
                                "Jeff:From now on you will be a spy, try to get into the center of moscow and get some news, and if you can try to kill the president");
                            break;
                        case 2:
                            Console.WriteLine(
                                "No problem we get it, but  since you arent going to help us you need to leave the shelter");
                            Console.WriteLine($"{Name} leaves the shelter but gets shot");
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("Made by MrPedroGabriel123");
                    Console.WriteLine("MrAmos and Thalos helped my when I was stuck with any type of code");
                    Console.ReadKey();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
