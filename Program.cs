using System;
using Adventure.Models;

namespace Adventure
{
  public class Program
  {
    public static Game game;
    public static Player player;
    public static bool gameOver = false;

    static void Main()
    {
      Console.WriteLine("Escape from the Dungeon!");
      Console.WriteLine("Hint: CAPITAL letters are KEYWORDS for typing. Pay attention to them!");
      Console.WriteLine("Enter name:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter difficulty: ('E' for easy/'H' for hard)");
      char difficulty = Convert.ToChar(Console.ReadLine());
      Player.Name = name;
      game = new Game(name, difficulty);

      Console.WriteLine("You wake up and find yourself in a strange room.  How did you get here?  Well however that happened, you feel like you have to get out.");

      while(!gameOver)
      {
        gameOver = CheckGameOver();
        Game.ShowStats();
        game.RoomDescription();
        game.CallRoomCommands(AskCommands());
      }
    }

    public static string[] AskCommands()
    {
      Console.WriteLine(">>> What do you want to do next? (MOVE/LOOK/PICKUP/TALK/USE)");
      string commandString = Console.ReadLine().ToUpper();
      string[] commands = commandString.Split(" ");
      return commands;
    }

    public static bool CheckGameOver()
    {
      if(!game.CheckDoorLocked("7B"))
      {
        return true;
      }
      return false;
    }
  }
}