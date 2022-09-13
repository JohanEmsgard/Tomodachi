using System;
using System.Collections.Generic;

public class Tamagochi
{
   public void Printstats()
   {
      Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
   }
    private int hunger;
    private int boredom;
    private List<string> words = new List<string> (){"Meow"};
    private bool isAlive;
    private Random generator; 
    public string name;  



     public Tamagochi()
     {
        generator = new Random();
        isAlive = true;

     }

     public void Feed()
     {
      Console.WriteLine($"[{name}] is eating and becomeing less hungre");
      hunger -= 2;
      if (hunger < 0)
      {
         hunger = 0;
      }
     }


     public bool GetAlive()
     {
      return isAlive;
     }

     public void Hi()
     {
      int wordNum = generator.Next(words.Count);
      Console.WriteLine($"[{name}] said {words[wordNum]}");
     }



     public void reduceboredem()
     {
      Console.WriteLine($"[{name}] is having fun");
      boredom -= 2;
      if (boredom < 0)
      {
         boredom = 0;
      }

     }

} 
