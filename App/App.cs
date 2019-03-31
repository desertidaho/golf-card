using System;
using golf_card.Models;

namespace golf_card
{
  class App
  {
    Golfer player { get; set; }
    public void fore()
    {
      Console.WriteLine(@"I'll keep track of your score for you.
What is your name?");
      string name = Console.ReadLine().ToLower();
      name = name[0].ToString().ToUpper() + name.Substring(1);
      player = new Golfer(name);
      Console.Clear();
      Console.WriteLine($"Hi {name}, you'll be palying a difficult course today, good luck. Are you ready?");
      string ready = Console.ReadLine().ToLower();
      if (ready == "yes" || ready == "ya" || ready == "y")
      {
        Console.Clear();
        int y = 1;
        int total = 0;
        while (y <= 9)
        {
          if (y % 2 == 0)
          {
            Console.WriteLine($"Hole {y}, par 3.");
          }
          if (y % 2 != 0)
          {
            Console.WriteLine($"Hole {y}, par 4.");
          }
          Console.WriteLine("What is your score?");
          int x;
          Int32.TryParse(Console.ReadLine(), out x);
          total += x;
          if (x < 4)
          {
            Console.WriteLine($"{x}, you're amazing!");
          }
          else if (x == 4)
          {
            Console.WriteLine($"{x}, nice job.");
          }
          else
          {
            Console.WriteLine($"{x}, you need practice. Try harder.");
          }
          x += 1;
          y += 1;
          Console.WriteLine(" ");
        }
        Console.Clear();
        if (total <= 32)
        {
          Console.WriteLine($"Par for the course is 32, you shot a {total}, well done Tiger.");
          Console.WriteLine("See you next time.");
          Console.WriteLine("Goodbye.");
        }
        else if (total <= 36)
        {
          Console.WriteLine($"Par for the course is 32, you shot a {total}, not bad for a rookie.");
          Console.WriteLine("See you next time.");
          Console.WriteLine("Goodbye.");
        }
        else
        {
          Console.WriteLine($"Par for the course is 32, you shot a {total}, not your sport.");
          Console.WriteLine("Try a sport that doesn't take coordination or patience.");
          Console.WriteLine("Hope I don't see you out here again.");
          Console.WriteLine("Get out of here.");
        }
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Okay, go to the pro shop and let them know you're behind schedule.");
        Console.WriteLine("Come back later when you're ready. Stop wasting my time.");
      }
    }
  }
}
