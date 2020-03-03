using System;
using System.Collections.Generic;

namespace Adventure.Models
{
  public class Game
  {
    //public static Player Adventurer { get; set; }
    public char Difficulty { get; set; }
    public static string CurrentRoom { get; set; }
    public static RoomOne Room1 { get; set; }
    public static RoomTwoA Room2A { get; set; }
    public static RoomTwoB Room2B { get; set; }
    public static RoomThree Room3 { get; set; }
    public static RoomFour Room4 { get; set; }
    public static RoomFive Room5 { get; set; }
    public static RoomSix Room6 { get; set; }
    public static RoomSevenA Room7A { get; set; }
    public static RoomSevenB Room7B { get; set; }

    public Game(string name, char difficultyLevel)
    {
      //Adventurer = new Player(name);
      Difficulty = difficultyLevel;
      CurrentRoom = "1";
      Room1 = new RoomOne();
      Room2A = new RoomTwoA();
      Room2B = new RoomTwoB();
      Room3 = new RoomThree();
      Room4 = new RoomFour();
      Room5 = new RoomFive();
      Room6 = new RoomSix();
      Room7A = new RoomSevenA();
      Room7B = new RoomSevenB();
    }

    public static void ShowStats()
    {
      Console.WriteLine("============================");
      Console.WriteLine("Name: " + Player.Name);
      Console.WriteLine("HP: " + Player.HP);
      if (Player.Inventory.Count > 0)
      {
        Console.WriteLine("Inventory: " + string.Join(" ", Player.Inventory));
      }
      else
      {
        Console.WriteLine("Inventory: EMPTY");
      }
      Console.WriteLine("============================");
    }

    public void RoomDescription()
    {
      switch(CurrentRoom)
      {
        case "1":
          Console.WriteLine("The ROOM is full of JUNK with banana peels littering the floor.  You see a DOOR that is locked and a friendly looking MONKEY standing in the corner.  Now how to get through that DOOR...");
          break;
        case "2A":
          Console.WriteLine("The ROOM is surprisingly cleaner with a barred GATEWAY to the South with a neat line of BUTTONS on its front.  There also appears to be a small TUNNEL in the corner of the room that is just big enough to crawl through.");
          break;
        case "2B":
          Console.WriteLine("The ROOM is small and cramped with barely enough light to see.  A glimmer of something shiny catches your eye on the opposite wall.  It looks like a MIRROR.");
          break;
        case "3":
          Console.WriteLine("You see a CAT standing in front of a WINDOW. It's fixated its gaze on something behind the WINDOW. But wow, there is also an ELEVATOR in this ROOM. Looks like there is only one way to go -- up!");
          break;
        default:
          Console.WriteLine("Room number not found!");
          break;
      }
    }
    public void CallRoomCommands(string[] inputCommand)
    {
      switch(CurrentRoom)
      {
        case "1":
          Room1.RoomOneCommands(inputCommand);
          break;
        case "2A":
          Room2A.RoomTwoACommands(inputCommand);
          break;
        case "2B":
          Room2B.RoomTwoBCommands(inputCommand);
          break;
        case "3":
          Room3.RoomThreeCommands(inputCommand);
          break;
        default:
          break;
      }  
    }
    
    // Return true if door is locked
    public bool CheckDoorLocked()
    {
      switch(CurrentRoom)
      {
        case "1":
          return Room1.Door1Locked;
        case "2A":
          return Room2A.Door2Locked;
        case "3":
          return Room3.Door3Locked;
        case "4":
          return RoomFour.Door4Locked;
        default:
          return true; 
      }
    }

    public static void UnlockDoor()
    {
      switch(CurrentRoom)
      {
        case "1":
          Room1.Door1Locked = false;
          break;
        case "2A":
          Room2A.Door2Locked = false;
          break;
        case "3":
          Room3.Door3Locked = false;
          break;
        case "4":
          RoomFour.Door4Locked = false;
          break;
        default:
          break;
      }
    }
  }
}