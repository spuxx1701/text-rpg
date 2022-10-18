
using System;
using System.Collections.Generic;

namespace text_rpg
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Elk Elchson Productions presents: The Awesome Text RPG.");
      string player = SetupPlayer();
      Console.WriteLine("Game ends.");
    }

    static string SetupPlayer()
    {
      Console.WriteLine("Welcome! Please name your hero:");
      string playerName = Console.ReadLine();
      Console.WriteLine("Hello, " + playerName + "!");
      return playerName;
    }
  }
}