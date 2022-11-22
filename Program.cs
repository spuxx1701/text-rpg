
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
      Console.WriteLine("Where would you want to go?");
      string[] locations = { "Forest", "Mountains", "Castle" };
      for (int i = 0; i < locations.Length; i++)
      {
        Console.WriteLine("[" + i + "] " + locations[i]);
      }
      int number = AskForUserInput(0, locations.Length - 1);
      Console.WriteLine("You are heading to the " + locations[number]);
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
      string[] classNames = { "Mage", "Paladin", "Warrior" };
      string selectedClass = "";
      // Loop über das 'classNames' Array, i entspricht dem Index des jeweiligen Eintrags
      // (0, 1, 2, ...)
      for (int i = 0; i < classNames.Length; i++)
      {
        Console.WriteLine("[" + i + "] " + classNames[i]);
      }
      int number = AskForUserInput(0, classNames.Length - 1);
      selectedClass = classNames[number];
      Console.WriteLine("You are a " + selectedClass + "!");
      return selectedClass;
    }

    static int AskForUserInput(int minimum, int maximum)
    {
      string text = Console.ReadLine();
      int number = 0;
      try
      {
        number = int.Parse(text);
        if (number < minimum || number > maximum)
        {
          throw new IndexOutOfRangeException();
        }
      }
      catch (Exception)
      {
        Console.WriteLine("Please enter a valid number between " + minimum + " and " + maximum + "!");
        return AskForUserInput(minimum, maximum);
      }
      return number;
    }
  }
}