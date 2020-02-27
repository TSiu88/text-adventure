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
      Console.WriteLine("Hint: CAPITAL letters are KEYWORDS for typing. Pay attention to them!");
      Console.WriteLine("Enter name:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter difficulty: ('E' for easy/'H' for hard)");
      char difficulty = Convert.ToChar(Console.ReadLine());
      game = new Game(name, difficulty);

      ShowStats();
      Console.WriteLine("You wake up and find yourself in a strange room.  How did you get here?  Well however that happened, you feel like you have to get out.");

      Console.WriteLine("What do you want to do next? (MOVE/LOOK/PICKUP/TALK/USE)");
      string commandString = Console.ReadLine().ToUpper();
      string[] commands = commandString.Split(" ");

      switch(game.CurrentRoom) 
      {
        case 1:
          //Call first room method
          game.RoomDescription(1);
          game.RoomOne(commands);
          break;
        case 2:
          //Call second room method
          break;
        default:
          Console.WriteLine("Error, room not found");
          break;
      }

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