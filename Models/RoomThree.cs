using System;

namespace Adventure.Models
{
  public class RoomThree
  {
    public bool Door3Locked { get; set; }
    public bool Door4Locked { get; set; }
    public RoomThree()
    {
      Door3Locked = true;
      Door4Locked = true;
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
            Console.WriteLine("You press the up button and enter the ELEVATOR. Your ears are ringing. It feels like it's taking you a hundred floors up.");
            Game.CurrentRoom = "5";
          }
          else
          {
            Console.WriteLine("The ELEVATOR doors won't open as you press the up button.");
          }
          break;
        case "WINDOW":
          if (!Door4Locked)
          {
            Console.WriteLine("You climb up and go through the broken WINDOW.");
            Game.CurrentRoom = "4";
          }
          else
          {
            Console.WriteLine("You try to slide the WINDOW open but it's jammed.");
          }
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
          Console.WriteLine("There are ROCKs on the ground. The ELEVATOR doors are silvery, modern-looking with a BADGE-READER on the side. Meanwhile, the CAT is just standing there, purring and grooming itself. You notice it's wearing a COLLAR. It must have an owner. How did the CAT get lost here?");
          break;
        default:
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
        case "COLLAR":
          Console.WriteLine("You take a closer look at the CAT's COLLAR. Beside its nametag, there is a small ACCESS-CARD attached to the COLLAR. You take the ACCESS-CARD with you.");
          Player.Inventory.Add("ACCESS-CARD");
          break;
        default:
          break;
      }
    }
    private void RoomThreeTalkCase(string person)
    {
      switch(person)
      {
        case "CAT":
          Console.WriteLine("'Meow...' says the CAT. It looks like it wants you to do something for it.");
          break;
        default:
          break;
      }
    } // RoomThreeTalkCase ends
  }
}