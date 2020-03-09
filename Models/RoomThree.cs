using System;

namespace Adventure.Models
{
  public class RoomThree
  {
    public bool Door3Locked { get; set; }
    public RoomThree()
    {
      Door3Locked = true;
    }

    public void RoomThreeCommands(string[] commands)
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
            RoomThreeMoveCase(commands[1]);
            break; // MOVE case ends
          case "LOOK":
            RoomThreeLookCase(commands[1]);
            break; // LOOK case ends
          case "PICKUP":
            RoomThreePickupCase(commands[1]);
            break; // PICKUP case ends
          case "TALK":
            RoomThreeTalkCase(commands[1]); 
            break; // TALK case ends
          case "USE":
            Player.UseItem(commands);
            break; // USE case ends
          default:
            Console.WriteLine("Invalid command.  Please try again.");
            break;
            
        } // Command[0] switch ends
      } // Room Three ends
      Console.WriteLine("****************************");
    }

    private void RoomThreeMoveCase(string location)
    {
      switch(location)
      {
        case "ELEVATOR":
          if (!Door3Locked)
          {
            Console.WriteLine("Here we go... You press the up button and enter the ELEVATOR. Your ears are ringing. It feels like it's taking you a hundred floors up.");
            Game.CurrentRoom = "5";
          }
          else
          {
            Console.WriteLine("The ELEVATOR doors won't open as you press the up button.");
          }
          break;
        case "WINDOW":
          if (!RoomFour.Door4Locked)
          {
            Console.WriteLine("You climb up and go through the broken WINDOW.");
            Game.CurrentRoom = "4";
          }
          else
          {
            Console.WriteLine("You try to slide the WINDOW open but it's jammed.");
          }
          break;
        case "CAT":
          Console.WriteLine("You try to call the CAT. The CAT ignores you and continues to stare at something behind the WINDOW.");
          break;
        case "ROCK":
          Console.WriteLine("You kick a small ROCK on the ground out of boredom. Nothing special happens.");
          break;
        case "BADGE-READER":
          Console.WriteLine("The BADGE-READER is nailed down to the wall. Trying to budge it doesn't do anything.");
          break;
        default:
          Console.WriteLine("You try to move but you can't figure out how.");
          break;
      }
    } // RoomThreeMoveCase ends

    private void RoomThreeLookCase(string item)
    {
      switch(item)
      {
        case "ROOM":
          Console.WriteLine("You see ROCKs on the ground. The ELEVATOR doors are silvery, modern-looking with a BADGE-READER on the side. Meanwhile, the CAT is just standing there, purring and grooming itself. You notice the CAT is wearing a COLLAR. It must have an owner. How did the CAT get lost here? Why the randomly placed WINDOW there?");
          break;
        case "CAT":
          Console.WriteLine("You focus more on the CAT. It's wearing a COLLAR with something white and square-shaped attached to its COLLAR. Seems important.");
          break;
        case "ROCK":
          Console.WriteLine("ROCKs are on the ground. They look normal.");
          break;
        case "COLLAR":
          Console.WriteLine("You take a closer look at the CAT's COLLAR. Its COLLAR has a small white squared-shape ACCESS-CARD attached to it as the CAT moves around. You try to take the ACCESS-CARD but the CAT won't let you. Maybe you can try giving the CAT something it likes to get the CAT move closer to you...");
          break;
        case "ELEVATOR":
          Console.WriteLine("The ELEVATOR just looks like a normal, modern-day looking ELEVATOR to you. Except this one has a BADGE-READER for special granted access only. Maybe there's something somewhere that can grant you access using the ELEVATOR?");
          break;
        case "BADGE READER":
          Console.WriteLine("Just a BADGE READER that seems like it's connected to the ELEVATOR. Got to find something somewhere that can grant you access using the ELEVATOR...");
          break;
        case "WINDOW":
          Console.WriteLine("You look through the WINDOW and see a can of SARDINES placed on a table inside that doorless ROOM. No wonder the CAT's been eyeing on it!");
          break;
        case "SARDINES":
          Console.WriteLine("The CAT will for sure love the can of SARDINES. Now, how do I get to the other side of the WINDOW?");
          break;
        default:
          Console.WriteLine("You look at the air.  The air stares back...?");
          break;
      }
    } // RoomThreeLookCase ends

    private void RoomThreePickupCase(string item)
    {
      switch(item)
      {
        case "ROCK":
          Console.WriteLine("You pick up a medium-sized ROCK.");
          Player.Inventory.Add("ROCK");
          break;
        case "ACCESS-CARD":
          Console.WriteLine("The CAT won't even move closer to you. How could you pick up the ACCESS-CARD attached to its COLLAR, you wonder?");
          break;
        case "SARDINES":
          Console.WriteLine("The can of SARDINES is on the other side of the WINDOW. Got to find something to break the WINDOW with...");
          break;
        case "COLLAR":
          Console.WriteLine("The CAT won't even move closer to you. How could you pick up its COLLAR, you wonder?");
          break;
        case "CAT":
          Console.WriteLine("The CAT won't even move closer to you. It seems shy around strangers. The CAT won't even let you pet it. Somehow you think you've got to make friends with this CAT. But how?");
          break;
        default:
          Console.WriteLine("You try to pick up the air.  It wasn't interested.");
          break;
      } 
    }
    private void RoomThreeTalkCase(string person)
    {
      switch(person)
      {
        case "CAT":
          Console.WriteLine("'Meow...' says the CAT. ");
          Console.WriteLine("How will you reply? (HELLO/BYE)");
          string reply = Console.ReadLine().ToUpper();
          switch(reply)
          {
            case "HELLO":
              Console.WriteLine("You say HELLO to the CAT. The CAT won't even move closer to you. It seems shy around strangers. The CAT won't even let you pet it. You notice the CAT's gaze is fixed onto the can of SARDINES behind the WINDOW. It almost seems like the CAT wants you to get the SARDINES for it.");
              break;
            case "BYE":
              Console.WriteLine("'Meow...' the CAT goes back to minding its own business.");
              break;
            default:
              Console.WriteLine("'Meow?' The CAT looks confused.");
              break;
          }
          break;
        default:
          Console.WriteLine("You talk to yourself.  You wonder what you're doing.");
          break;
      }
    } // RoomThreeTalkCase ends
  }
}