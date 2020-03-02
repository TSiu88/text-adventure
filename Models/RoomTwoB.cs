using System;

namespace Adventure.Models
{
  public class RoomTwoB
  {
    public RoomTwoB()
    {

    }

    public void RoomTwoBCommands(string[] commands)
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
            RoomTwoBMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomTwoBLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomTwoBPickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomTwoBTalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room TwoB ends
      Console.WriteLine("****************************");
    }

    private void RoomTwoBMoveCase(string location)
    {
      switch(location)
      {
        case "LOCATION":
          break;
        default:
          Console.WriteLine("You try to move but you can't figure out how.");
          break;
      }
    } // RoomTwoBMoveCase ends

    private void RoomTwoBLookCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    } // RoomTwoBLookCase ends

    private void RoomTwoBPickupCase(string item)
    {
      switch(item)
      {
        case "ITEM":
          break;
        default:
          break;
      }
    }
    private void RoomTwoBTalkCase(string person)
    {
      switch(person)
      {
        case "PERSON":
          break;
        default:
          break;
      }
    } // RoomTwoBTalkCase ends
  }
}