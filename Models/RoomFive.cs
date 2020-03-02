using System;

namespace Adventure.Models
{
  public class RoomFive
  {
    public bool Door5Locked { get; set; }
    public RoomFive()
    {
      Door5Locked = true;
    }

    public void RoomFiveCommands(string[] commands)
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
            RoomFiveMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomFiveLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomFivePickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomFiveTalkCase(commands[1]); 
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

    private void RoomFiveMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door5Locked)
          {
            Console.WriteLine("The unlocked DOOR opens easily and you walk through.");
            Game.CurrentRoom = "2A";
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
    } // RoomFiveMoveCase ends

    private void RoomFiveLookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomFiveLookCase ends

    private void RoomFivePickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomFiveTalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomFiveTalkCase ends
  }
}