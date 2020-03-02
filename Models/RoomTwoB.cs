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
        case "TUNNEL":
          Console.WriteLine("You move back into the TUNNEL, leaving the lone MIRROR behind.");
          break;
        case "MIRROR":
          Console.WriteLine("You try to lift the MIRROR off the wall but it is too heavy and stuck in place.");
          break;
        case "SPOON":
          Console.WriteLine("You try to bend the SPOON with your mind, but all you get is a slight headache for your trouble.");
          break;
        default:
          Console.WriteLine("You try to move it but you can't figure out how.");
          break;
      }
    } // RoomTwoBMoveCase ends

    private void RoomTwoBLookCase(string item)
    {
      switch(item)
      {
        case "ROOM":
          Console.WriteLine("The ROOM is dark and dusty with a large MIRROR covering the far wall.  Looking down you can see a SPOON sticking out of the dirt of the TUNNEL.");
          break;
        case "MIRROR":
          Console.WriteLine("You look into the large dusty MIRROR that takes up most of the wall and can make out the outline of your reflection.  How did it get in this dark cramped place?");
          break;
        case "SPOON":
          Console.WriteLine("A rusty old SPOON sticks out of the dirt and the entrance to the TUNNEL.  I guess people really dig TUNNELs with SPOONs?");
          break;
        default:
          Console.WriteLine("You look at the air.  The air stares back...?");
          break;
      }
    } // RoomTwoBLookCase ends

    private void RoomTwoBPickupCase(string item)
    {
      switch(item)
      {
        case "SPOON":
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
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
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomTwoBTalkCase ends
  }
}