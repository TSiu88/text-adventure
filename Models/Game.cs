using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Game
  {
    public Player Adventurer { get; set; }
    public char Difficulty { get; set; }
    public int CurrentRoom { get; set; }
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
      Door1Locked = true;
      Door2Locked = true;
      Door3Locked = true;
      Door4Locked = true;
      Door5Locked = true;
      Door6Locked = true;
      Door7Locked = true;
    }

    public void RoomDescription(int roomNumber)
    {
      switch(roomNumber)
      {
        case 1:
          Console.WriteLine("The room is full of JUNK with banana peels littering the floor.  You see a DOOR that is locked and a friendly looking MONKEY standing in the corner.  Now how to get through that DOOR...");
          break;
      }
    }

    public void RoomOne(string[] commands)
    {
      if (commands.Length < 2)
      {
        Console.WriteLine("Invalid command. Please try again.");
      }
      else
      {
        switch(commands[0])
        {
          case "MOVE":
            switch(commands[1])
            {
              case "DOOR":
                if (!Door1Locked)
                {
                  Console.WriteLine("The unlocked DOOR opens easily and you walk through.");
                  CurrentRoom = 2;
                }
                else
                {
                  Console.WriteLine("This DOOR is locked up tight.  I can't open it without a KEY.");
                }
                break;
              default:
                Console.WriteLine("You try to move but you can't figure out how.");
                break;
            }
            break;
          case "LOOK":
            switch(commands[1])
            {
              case "ROOM":
                Console.WriteLine("You search the room.  The piles of JUNK and bananas scattered about make it difficult to traverse.  The MONKEY stares at you from his spot in the corner.");
                break;
              case "JUNK":
                Console.WriteLine("You shift through one of the piles of junk on the floor and notice a large KEY beneath one of them.");
                break;
              case "MONKEY":
                Console.WriteLine("For being a different species he looks remarkably intelligent. Maybe you can TALK to him?");
              break;
              case "KEY":
                Console.WriteLine("A large KEY. Looks like it should open a DOOR.  Looks important enough anyways.");
                break;
              default:
                Console.WriteLine("You look at the air.  The air stares back...?");
                break;
            }
            break;
          case "PICKUP":

          break;
          case "TALK":

          break;
          case "USE":

          break;
        }
      }
    }

  }
}