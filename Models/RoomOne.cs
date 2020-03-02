using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class RoomOne
  {
    public bool Door1Locked { get; set; }

    public RoomOne()
    {
      Door1Locked = true;
    }
    public void RoomOneCommands(string[] commands)
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
            RoomOneMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomOneLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomOnePickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomOneTalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room One ends
      Console.WriteLine("****************************");
    }

    private void RoomOneMoveCase(string location)
    {
      switch(location)
      {
        case "DOOR":
          if (!Door1Locked)
          {
            Console.WriteLine("The unlocked DOOR opens easily and you walk through.");
            Game.CurrentRoom = "2a";
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
    } // RoomOneMoveCase ends

    private void RoomOneLookCase(string item)
    {
      switch(item)
      {
        case "ROOM":
          Console.WriteLine("You search the ROOM.  The piles of JUNK and bananas scattered about make it difficult to traverse.  The MONKEY stares at you from his spot in the corner.");
          break;
        case "JUNK":
          Console.WriteLine("You shift through one of the piles of JUNK on the floor and notice a large KEY beneath one of them.");
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
    } // RoomOneLookCase ends

    private void RoomOnePickupCase(string item)
    {
      switch(item)
      {
        case "KEY":
          Console.WriteLine("You pick up the large KEY from the pile of JUNK.  It is surprisingly heavy for its size.");
          Player.Inventory.Add("HEAVY-KEY");
          break;
        case "JUNK":
          Console.WriteLine("You try to pick up some JUNK but it all looks useless. It'll just take up space in your pocket I guess.");
          Player.Inventory.Add("JUNK");
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
          break;
      } 
    } // RoomOnePickupCase ends

    private void RoomOneTalkCase(string item)
    {
      switch(item)
      {
        case "MONKEY":
          Console.WriteLine("'Good day!' says the MONKEY.  'Do you need some HELP?'");
          Console.WriteLine("How will you reply? (HELP/BYE/INFO)");
          string reply = Console.ReadLine().ToUpper();
          switch(reply)
          {
            case "HELP":
              Console.WriteLine("'You can LOOK ROOM to look around and you can even combine COMMAND KEYWORD and see what happens!'");
              Console.WriteLine("'USE (ITEM-NAME) (OBJECT) to use items from your inventory on an object!'");
              Console.WriteLine("Talk to me again if you need anything else!");
              break;
            case "BYE":
              Console.WriteLine("'OK. Bye.'");
              break;
            case "INFO":
              Console.WriteLine("'Well I've been stuck in this ROOM just like you.  Don't know why, but there's plenty of bananas so I'm fine here.'");
              break;
            default:
              Console.WriteLine("'Sorry I don't understand what you're saying.'");
              break;
          }
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomOneTalkCase ends
  }
  
}