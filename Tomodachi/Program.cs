using System;

Console.WriteLine("Welcome to Tamagotchi");

Tamagochi s1 = new Tamagochi(); 

Console.WriteLine("Pick a name for your Tamagotchi");
s1.name = Console.ReadLine();

Console.WriteLine($"{s1.name} is a wonderfull name");

while (s1.GetAlive() == true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Feed");
    Console.WriteLine("Learn a new word");
    Console.WriteLine("Play");
    Console.WriteLine("Don't do shit");
    string action = Console.ReadLine();

    if (action == "1")
    {
        s1.Feed();

    }
    if (action == "2")
    {
        s1.Hi();
    }

    if (action == "3")
    {
        s1.reduceboredem();
    }

    if (action == "4")
    {
        s1.Tick();
    }
    s1.Tick();
    
}

Console.WriteLine("Your Tamagochi died :(. IT*S DEATH IS OVER 9000");
Console.WriteLine("Press enter to exit");
Console.ReadLine();


