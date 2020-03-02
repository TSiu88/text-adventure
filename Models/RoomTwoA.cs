using System;

namespace Adventure.Models
{
  public class RoomTwoA
  {
    public bool Door2Locked { get; set; }
    public RoomTwoA()
    {
      Door2Locked = true;
    }

    public void RoomTwoACommands(string[] commands)
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
            RoomTwoAMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomTwoALookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomTwoAPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomTwoATalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room TwoA ends
      Console.WriteLine("****************************");
    }

    private void RoomTwoAMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door2Locked)
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
    } // RoomTwoAMoveCase ends

    private void RoomTwoALookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomTwoALookCase ends

    private void RoomTwoAPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomTwoATalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomTwoATalkCase ends
  }
}