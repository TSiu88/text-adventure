using System;

namespace Adventure.Models
{
  public class RoomSevenA
  {
    public bool Door7ALocked { get; set; }
    public RoomSevenA()
    {
      Door7ALocked = true;
    }

    public void RoomSevenACommands(string[] commands)
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
            RoomSevenAMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomSevenALookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomSevenAPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomSevenATalkCase(commands[1]); 
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

    private void RoomSevenAMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          if (!Door7ALocked)
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
    } // RoomSevenAMoveCase ends

    private void RoomSevenALookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomSevenALookCase ends

    private void RoomSevenAPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomSevenATalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomSevenATalkCase ends
  }
}