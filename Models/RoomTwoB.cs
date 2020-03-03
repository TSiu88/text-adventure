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
          Console.WriteLine("You pick up the SPOON, though it doesn't look like a key kind of item.");
          Player.Inventory.Add("SPOON");
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
        case "MIRROR":
          Console.WriteLine("You greet your reflection and it greets you back! 'I haven't talked to anyone in sooo long!' your voice emanates back to you from the MIRROR.");
          Console.WriteLine("Despite being unnerved from the talking MIRROR, you decide to ask it for its opinion on a topic: (REFLECTION/GATEWAY/SPOON)");
          string reply = Console.ReadLine().ToUpper();
          switch(reply)
          {
            case "REFLECTION":
              Console.WriteLine("'Who is that girl I see? Staring straight back at me.  Why is my REFLECTION someone I don't know...' the MIRROR sings to you in your own voice.  It continues singing but nothing useful is said.");
              break;
            case "GATEWAY":
              Console.WriteLine("'Oh I used to be on that side of the wall but then I was moved here for some reason.' says the MIRROR. 'Is the secret PANEL still there?'");
              break;
            case "SPOON":
              Console.WriteLine("'SPOONs can be useful for escapes, or so I hear'");
              break;
            default:
              Console.WriteLine("The MIRROR ignores your reply, continuing to chat to itself about your appearance.");
              break;
          }
          break;
        case "SPOON":
          Console.WriteLine("You use the SPOON as a microphone and start loudly singing your favorite song.  Its a lot of fun, but not a very good use of your time.");
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomTwoBTalkCase ends
  }
}