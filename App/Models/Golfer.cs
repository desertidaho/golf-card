using System;
using System.Collections.Generic;

namespace golf_card.Models
{
  public class Golfer
  {
    public string Name { get; set; }
    public List<Score> Scores { get; set; }



    public Golfer()
    {
      Scores = new List<Score>();
    }
  }
}