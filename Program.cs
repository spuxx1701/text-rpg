
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
      string className = SetupClass(player);
      Console.WriteLine("You are a " + className + "!");
      Console.WriteLine("Game ends.");
    }

    static string SetupPlayer()
    {
      Console.WriteLine("Welcome! Please name your hero:");
      string playerName = Console.ReadLine();
      Console.WriteLine("Hello, " + playerName + "!");
      return playerName;
    }

    static string SetupClass(string player)
    {
      Console.WriteLine(player + ", choose your class!");
      string[] classNames = { "Mage", "Rogue" };
      Console.WriteLine("[0] " + classNames[0]);
      Console.WriteLine("[1] " + classNames[1]);
      string value = Console.ReadLine();
      if (value == "0" || value == classNames[0])
      {
        return classNames[0];
      }
      else
      {
        return classNames[1];
      }
    }
  }
}