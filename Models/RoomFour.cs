using System;

namespace Adventure.Models
{
  public class RoomFour
  {
    public static bool Door4Locked { get; set; }

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
        case "WINDOW":
          Console.WriteLine("You go through the broken WINDOW and back into the ROOM with the ELEVATOR entrance.");
          Game.CurrentRoom = "3";
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
        case "ROOM":
          Console.WriteLine("You look around the doorless ROOM and there's just an old rustic table with a can of SARDINES placed on it. What an odd space this is.");
          break;
        default:
          Console.WriteLine("You look at the air.  The air stares back...?");
          break;
      }
    } // RoomFourLookCase ends
 
    private void RoomFourPickupCase(string item)
    {
      switch(item)
      {
        case "SARDINES":
          Console.WriteLine("You pick up a can of SARDINES.");
          Player.Inventory.Add("SARDINES");
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
          break;
      } 
    } 
    private void RoomFourTalkCase(string person)
    {
      switch(person)
      {
        case "CAT":
          Console.WriteLine("'MEOWWWWWWWWW'");
          Console.WriteLine("Sounds like it's very excited. The CAT is waiting for you by the WINDOW.");
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomFourTalkCase ends
  }
}