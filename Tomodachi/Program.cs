using System;

Console.WriteLine("Welcome to Tamagotchi");

Tamagochi s1 = new Tamagochi(); 

Console.WriteLine("Pick a name for your Tamagotchi");
s1.name = Console.ReadLine();

Console.WriteLine($"{s1.name} is a wonderfull name");

while (Tamagochi.GetAlive() == true)
{

}





Console.ReadLine();


