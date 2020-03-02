using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Game
  {
    public Player Adventurer { get; set; }
    public char Difficulty { get; set; }
    public int CurrentRoom { get; set; }
    public RoomOne Room1 { get; set; }
    public bool Door1Locked { get; set; }
    public bool Door2Locked { get; set; }
    public bool Door3Locked { get; set; }
    public bool Door4Locked { get; set; }
    public bool Door5Locked { get; set; }
    public bool Door6Locked { get; set; }
    public bool Door7Locked { get; set; }

    public Game(string name, char difficultyLevel)
    {
      Adventurer = new Player(name);
      Difficulty = difficultyLevel;
      CurrentRoom = 1;
      Room1 = new RoomOne();
      Door1Locked = true;
      Door2Locked = true;
      Door3Locked = true;
      Door4Locked = true;
      Door5Locked = true;
      Door6Locked = true;
      Door7Locked = true;
    }

    public void ShowStats()
    {
      Console.WriteLine("============================");
      Console.WriteLine("Name: " + Adventurer.Name);
      Console.WriteLine("HP: " + Adventurer.HP);
      if (Adventurer.Inventory.Count > 0)
      {
        Console.WriteLine("Inventory: " + string.Join(" ", Adventurer.Inventory));
      }
      else
      {
        Console.WriteLine("Inventory: EMPTY");
      }
      Console.WriteLine("============================");
    }

    public void RoomDescription(int roomNumber)
    {
      switch(roomNumber)
      {
        case 1:
          Console.WriteLine("The ROOM is full of JUNK with banana peels littering the floor.  You see a DOOR that is locked and a friendly looking MONKEY standing in the corner.  Now how to get through that DOOR...");
          break;
        default:
          Console.WriteLine("Room number not found!");
          break;
      }
    }

    public void CallRoomCommands(string[] inputCommand)
    {
      switch(CurrentRoom)
      {
        case 1:
          Room1.RoomOneCommands(inputCommand);
          break;
        default:
          break;
      }
         
    }
    
  }
}