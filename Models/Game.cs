using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Game
  {
    public Player Adventurer { get; set; }
    public char Difficulty { get; set; }
    public int CurrentRoom { get; set; }
    public bool Door1Locked { get; set; }
    public bool Door2Locked { get; set; }
    public bool Door3Locked { get; set; }
    public bool Door4Locked { get; set; }
    public bool Door5Locked { get; set; }
    public bool Door6Locked { get; set; }
    public bool Door7Locked { get; set; }

    public Game(string name, char difficultyLevel)
    {
      Adventurer = new Player(name);
      Difficulty = difficultyLevel;
      CurrentRoom = 1;
      Door1Locked = true;
      Door2Locked = true;
      Door3Locked = true;
      Door4Locked = true;
      Door5Locked = true;
      Door6Locked = true;
      Door7Locked = true;
    }

    public void ShowStats()
    {
      Console.WriteLine("============================");
      Console.WriteLine("Name: " + Adventurer.Name);
      Console.WriteLine("HP: " + Adventurer.HP);
      if (Adventurer.Inventory.Count > 0)
      {
        Console.WriteLine("Inventory: " + string.Join(" ", Adventurer.Inventory));
      }
      else
      {
        Console.WriteLine("Inventory: EMPTY");
      }
      Console.WriteLine("============================");
    }

    public void RoomDescription(int roomNumber)
    {
      switch(roomNumber)
      {
        case 1:
          Console.WriteLine("The ROOM is full of JUNK with banana peels littering the floor.  You see a DOOR that is locked and a friendly looking MONKEY standing in the corner.  Now how to get through that DOOR...");
          break;
        default:
          Console.WriteLine("Room number not found!");
          break;
      }
    }

    public void RoomOne(string[] commands)
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
                      Door1Locked = false;
                      Adventurer.Inventory.Remove("HEAVY-KEY");
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
                default:
                  Console.WriteLine("You try to use an item that you can't find.  It doesn't just exist.");
                  break;
              } // ITEM switch ends
            } // else ends
              break;
            default:
              Console.WriteLine("Invalid command.  Please try again.");
              break; // USE case ends
            
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
            CurrentRoom = 2;
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
          Adventurer.Inventory.Add("HEAVY-KEY");
          break;
        case "JUNK":
          Console.WriteLine("You try to pick up some JUNK but it all looks useless. It'll just take up space in your pocket I guess.");
          Adventurer.Inventory.Add("JUNK");
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