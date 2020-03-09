using System;

namespace Adventure.Models
{
  public class RoomSevenB
  {
    public bool Door7BLocked { get; set; }
    public RoomSevenB()
    {
      Door7BLocked = true;
    }

    public void RoomSevenBCommands(string[] commands)
    {
      Console.WriteLine("****************************");
      if (commands.Length < 2)
      {
        Console.WriteLine("Invalid command. Please try again.");
      }
      else
      {
        // Command switch start
        switch(commands[0])
        {
          case "MOVE":
            RoomSevenBMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomSevenBLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomSevenBPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomSevenBTalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room SevenB ends
      Console.WriteLine("****************************");
    }

    private void RoomSevenBMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door7BLocked)
          {
            Console.WriteLine("The unlocked DOOR opens easily and you walk through.");
            Game.CurrentRoom = "2A";
            // Gameover = true
          }
          else
          {
            Console.WriteLine("This DOOR is locked up tight.  I can't open it without a KEY.");
          }
          break;
        default:
          Console.WriteLine("You try to move it but you can't figure out how.");
          break;
      }
    } // RoomSevenBMoveCase ends

    private void RoomSevenBLookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          Console.WriteLine("You look at the air.  The air stares back...?");
          break;
      }
    } // RoomSevenBLookCase ends

    private void RoomSevenBPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
          break;
      }
    }
    private void RoomSevenBTalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomSevenBTalkCase ends
  }
}