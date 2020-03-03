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
              default:
                Console.WriteLine("You try to use the JUNK but it's still useless.");
                break;
            }
            break;
          case "ROCK":
            switch(target)
            {
              case "WINDOW":
                Console.WriteLine("You throw the ROCK at the WINDOW. It was a nice, clean shot! All the glass shattered and made space big enough for you to go through.");
                RoomFour.Door4Locked = false;
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
                Console.WriteLine("You open the can of SARDINES for the CAT. That got the CAT super excited. It's so happy that it wants to give you something back."); // cat returns something?
                Game.UnlockDoor();
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
                Console.WriteLine("You tap your ACCESS-CARD onto the BADGE-READER. The elevator lights up and opens its doors for you.");
                Game.UnlockDoor();
                break;
              default:
                Console.WriteLine("You tap your ACCESS-CARD randomly onto the walls. Nothing happens.");
                break;
            }
            break;
          default:
            Console.WriteLine("You try to use an item that you can't find.  It doesn't just exist.");
            break;
        } // ITEM switch ends
      } // else ends
    }
  }
}