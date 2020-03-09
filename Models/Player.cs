using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Player
  {
    public static string Name { get; set; }
    public static int HP { get; set; }
    public static List<string> Inventory { get; set; }

    static Player()
    {
      Name = "";
      HP = 10;
      Inventory = new List<string> ();
    }

    public static void UseItem(string[] commands)
    {
      string item = commands[1];
      if (commands.Length < 3)
      {
        Console.WriteLine("Nothing to use item on! Please try again with USE (ITEM) (TARGET-OBJECT).");
      }
      else
      {
        string target = commands[2];
        switch(item)
        {
          case "HEAVY-KEY":
            switch(target)
            {
              case "DOOR":
                Console.WriteLine("You insert the KEY into the DOOR and it swings open easily.  You can now MOVE through the DOOR.");
                Game.UnlockDoor();
                Inventory.Remove("HEAVY-KEY");
                break;
              case "JUNK":
                Console.WriteLine("You try to use the KEY on the JUNK.  It's useless and nothing happens.");
                break;
              default:
                Console.WriteLine("You try to use the KEY to unlock an invisible air portal.  It doesn't work since those don't exist.");
                break;
            }
            break;
          case "JUNK":
            switch(target)
            {
              case "HEAVY-KEY":
                Console.WriteLine("You bang the JUNK against the KEY in hopes that it will open something.  It doesn't.");
                break;
              case "SPOON":
                Console.WriteLine("You lift some JUNK in the SPOON and pretend to eat it.  Mmm JUNK food is delicious...not.");
                break;
              default:
                Console.WriteLine("You try to use the JUNK but it's still useless.");
                break;
            }
            break;
          case "SPOON":
            switch(target)
            {
              case "JUNK":
                Console.WriteLine("You lift some JUNK in the SPOON and pretend to eat it.  Mmm JUNK food is delicious...not.");
                break;
              case "MIRROR":
                Console.WriteLine("You contemplate trying to break the MIRROR with your SPOON but it didn't seem like a good use of your time.");
                break;
              case "BUTTONS":
                Console.WriteLine("You tap the SPOON on the BUTTONS.  It did not divine the correct answer of what to push.");
                break;
              case "TUNNEL":
                Console.WriteLine("You use the SPOON to try to widen the mouth of the TUNNEL.  After taking 30 minutes to widen it by half an inch you decide this will take forever and stop.");
                break;
              default:
                Console.WriteLine("If you were expecting to be SPOON-fed something, this is not the SPOON to use.");
                break;
            }
            break;
          case "ROCK":
            switch(target)
            {
              case "WINDOW":
                Console.WriteLine("You throw the ROCK at the WINDOW. It was a nice, clean shot! All the glass shattered and made space big enough for you to go through.");
                RoomFour.Door4Locked = false;
                Inventory.Remove("ROCK");
                break;
              default:
                Console.WriteLine("You throw the ROCK up in the air and catch it again. Seems like gravity works fine here.");
                break;
            }
            break;
          case "SARDINES":
            switch(target)
            {
              case "CAT":
                Console.WriteLine("You open the can of SARDINES for the CAT. That got the CAT super excited! It's so happy that it slides its body onto your leg and lets you pet it. You remember there is something important attached to its COLLAR. The CAT lets you take the ACCESS-CARD with you.");
                Inventory.Remove("SARDINES");
                Inventory.Add("ACCESS-CARD");
                break;
              default:
                Console.WriteLine("You fail to use the can of SARDINES.");
                break;
            }
            break;
          case "ACCESS-CARD":
            switch(target)
            {
              case "BADGE-READER":
                Console.WriteLine("You tap your ACCESS-CARD onto the BADGE-READER. The ELEVATOR lights up and opens its doors for you.");
                Game.UnlockDoor();
                break;
              default: 
                Console.WriteLine("You tap your ACCESS-CARD randomly onto the walls. Nothing happens.");
                break;
            } 
            break;
          default:
            Console.WriteLine("You try to use an item that you can't find.  It just doesn't exist.");
            break;
        } // ITEM switch ends
      } // else ends
    }
  }
}