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
        case "GATEWAY":
          if (!Door2Locked)
          {
            Console.WriteLine("To your surprise, the barred GATEWAY slides down smoothly into the floor and you walk through.");
            Game.CurrentRoom = "3";
          }
          else
          {
            Console.WriteLine("The bars blocking this GATEWAY don't budge no matter how much you pull.  Perhaps one of the BUTTONS on its front will do something.");
          }
          break;
        case "TUNNEL":
          Console.WriteLine("You get down on your stomach and start to crawl through the narrow opening of the TUNNEL.  It's a tight fit, but you manage to squeeze through.");
          Game.CurrentRoom = "2B";
          break;
        default:
          Console.WriteLine("You try to move it but you can't figure out how.");
          break;
      }
    } // RoomTwoAMoveCase ends

    private void RoomTwoALookCase(string item)
    {
      switch(item)
      {
        case "ROOM":
          Console.WriteLine("You search the ROOM for something useful to get through the latest obstacle.  There's a DOORMAT with a picture of a red animal on it, but other than that the floor is clean and clear... other than the pile of dirt next to the TUNNEL.");
          break;
        case "BUTTONS":
          Console.WriteLine("A line of shiny round BUTTONS gleam on the face of the barred GATEWAY.  You wonder what would happen if you were to press them.");
          break;
        case "TUNNEL":
          Console.WriteLine("A narrow dark TUNNEL has been dug out of a corner on the east side of the ROOM.  It will be a tight fit, but it looks like you can pass without getting stuck.");
          break;
        case "GATEWAY":
          Console.WriteLine("A fancy GATEWAY door with decorative bars blocks your path.  There is no doorknob to be seen, but there are several BUTTONS lined up on its face.");
          break;
        case "DOORMAT":
          Console.WriteLine("You try to figure out what kind of animal this DOORMAT is trying to depict.  At one angle it looks like a bird, but at another angle it looks like a fish.");
          break;
        default:
          Console.WriteLine("You look at the air.  The air stares back...?");
          break;
      }
    } // RoomTwoALookCase ends

    private void RoomTwoAPickupCase(string item)
    {
      switch(item)
      {
        case "GATEWAY":
          Console.WriteLine("Nice try but you can't pick up a GATEWAY even if it is barring your path.");
          break;
        case "DOORMAT":
          Console.WriteLine("You lift the DOORMAT hoping for a clue on what button to press, but there is nothing there but the name 'Herring'.");
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
          break;
      }
    }
    private void RoomTwoATalkCase(string thing)
    {
      switch(thing)
      {
        case "GATEWAY":
          Console.WriteLine("You try different versions of 'Open Sesame' and 'Abracadabra' but no magic words can get this GATEWAY to budge.");
          break;
        case "DOORMAT":
          Console.WriteLine("You start a one-sided discussion with this DOORMAT on what it is trying to say.  You eventually decide to stop being distracted and focus on the task of escaping.");
          break;
        case "BUTTONS":
          Console.WriteLine("You try to persuade the BUTTONS to tell you which one of them to press.  They don't say a word.");
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomTwoATalkCase ends
  }
}