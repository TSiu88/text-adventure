using System;

namespace Adventure.Models
{
  public class RoomSix
  {
    public bool Door6Locked { get; set; }
    public RoomSix()
    {
      Door6Locked = true;
    }

    public void RoomSixCommands(string[] commands)
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
            RoomSixMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomSixLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomSixPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomSixTalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room Six ends
      Console.WriteLine("****************************");
    }

    private void RoomSixMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door6Locked)
          {
            Console.WriteLine("The unlocked DOOR opens easily and you walk through.");
            Game.CurrentRoom = "7A";
          }
          else
          {
            Console.WriteLine("This DOOR is locked up tight.  I can't open it without a KEY.");
          }
          break;
        case "BACK":
          Game.CurrentRoom = "6";
          break;
        default:
          Console.WriteLine("You try to move but you can't figure out how.");
          break;
      }
    } // RoomSixMoveCase ends

    private void RoomSixLookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomSixLookCase ends

    private void RoomSixPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomSixTalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomSixTalkCase ends
  }
}