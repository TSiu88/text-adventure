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
          Console.WriteLine("You go through the broken WINDOW.");
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
          Console.WriteLine("This is a very small ROOM, almost like storage space without any doors. Hmm, weird. There's just a can of SARDINES that you saw earlier. You look around the room and see an ACCESS-CARD hanging on the wall behind you.");
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
          Console.WriteLine("You pick up a can of SARDINES");
          Player.Inventory.Add("SARDINES");
          break;
        case "ACCESS-CARD":
          Console.WriteLine("You take the ACCESS-CARD. It is plain white which reminds you of your school's security access card that you can tap on any BADGE-READER in your school building.");
          Player.Inventory.Add("ACCESS-CARD");
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
          Console.WriteLine("Sounds like it's very excited. The CAT is standing next the WINDOW.");
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomFourTalkCase ends
  }
}