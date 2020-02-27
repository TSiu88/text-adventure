using System;
using System.Collections.Generic;
using System.Linq;
using Adventure.Models;

namespace Adventure
{
  public class Program
  {
    public static Game game;
    public static Player player;

    static void Main()
    {
      Console.WriteLine("Escape from the Dungeon!");
      Console.WriteLine("Enter name:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter difficulty: ('E' for easy/'H' for hard)");
      char difficulty = Convert.ToChar(Console.ReadLine());
      game = new Game(name, difficulty);

      ShowStats();
      Console.WriteLine("");
    }

    public static void ShowStats()
    {
      Console.WriteLine("============================");
      Console.WriteLine("Name: " + game.Adventurer.Name);
      Console.WriteLine("HP: " + game.Adventurer.HP);
      if (game.Adventurer.Inventory.Count > 0)
      {
        Console.WriteLine("Inventory: " + string.Join(" ", game.Adventurer.Inventory));
      }
      else
      {
        Console.WriteLine("Inventory: EMPTY");
      }
      Console.WriteLine("============================");
    }
  }
}