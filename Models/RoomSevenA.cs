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
      } // Room SevenA ends
      Console.WriteLine("****************************");
    }

    private void RoomSevenAMoveCase(string location)
    {
      switch(location)
      {
        case "STAIRS":
          Console.WriteLine("You walk down the damp STAIRS, following the sound of running water.");
          break;
        case "LEDGE":
          Console.WriteLine("You climb back through the hole of the TRAPDOOR onto the LEDGE outside.");
          Game.CurrentRoom = "6";
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