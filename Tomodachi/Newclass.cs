using System;

public class Newclass
{
    private int hunger;
    private int boredom;
    private List<string> words = new List<string> (){"Meow"};
    private bool isAlive;
    private Random generator; 
    public string name;  


     public Newclass()
     {
        generator = new Random();
        isAlive = true;

     }

     public void feed()
     {
        Console.WriteLine();
        hunger -=2; 
        if (hunger < 0)
        {
            hunger = 0;
        }
     }

} 
