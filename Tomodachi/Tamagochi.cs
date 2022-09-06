using System;

public class Tamagochi
{
    private int hunger;
    private int boredom;
    private List<string> words = new List<string> (){"Meow"};
    private bool isAlive;
    private Random generator; 
    public string name;  
    public void feed;
    public void Hi;
    public void Teach(string word);


     public Tamagochi()
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

     public boredom()
     {

     }

     public hunger()
     {

     }

     public feed()
     {

     }

     public Hi()
     {

     }

     public Teach()
     {
      
     }





} 
