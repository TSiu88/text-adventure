using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Player
  {
    public string Name { get; set; }
    public int HP { get; set; }
    public List<string> Inventory { get; set; }

    public Player(string name)
    {
      Name = name;
      HP = 10;
      List<string> Inventory = new List<string> ();
    }
  }
}