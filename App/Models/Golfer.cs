using System;
using System.Collections.Generic;

namespace golf_card.Models
{
  public class Golfer
  {
    public string Name { get; set; }
    // List<Score> Scores { get; set; }



    public Golfer(string name)
    {
      Name = name;
      // Scores = new List<Score>();
    }
  }
}