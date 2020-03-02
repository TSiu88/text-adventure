using System;

namespace Adventure.Models
{
  public class RoomFour
  {
    public bool Door4Locked { get; set; }
    public RoomFour()
    {
      Door4Locked = true;
    }

    public void RoomFourCommands(string[] commands)
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
            RoomFourMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomFourLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomFourPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomFourTalkCase(commands[1]); 
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

    private void RoomFourMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door4Locked)
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
    } // RoomFourMoveCase ends

    private void RoomFourLookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomFourLookCase ends

    private void RoomFourPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomFourTalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomFourTalkCase ends
  }
}