using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Game
  {
    public Player Adventurer { get; set; }
    public char Difficulty { get; set; }

    public Game(string name, char difficultyLevel)
    {
      Adventurer = new Player(name);
      Difficulty = difficultyLevel;
    }


  }
}