using System;
using System.Collections.Generic;

namespace Adventure
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Escape from the Dungeon!");
      Console.WriteLine("Enter name:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter difficulty: ('E' for easy/'H' for hard)");
      char difficulty = Convert.ToChar(Console.ReadLine());
    }
  }
}