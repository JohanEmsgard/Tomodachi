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
    
}


Console.WriteLine("Press enter to exit");
Console.ReadLine();


