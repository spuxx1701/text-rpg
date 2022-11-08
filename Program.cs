
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
      string value = Console.ReadLine();
      // Prüfen, ob sich 'value' in eine Zahl (int) konvertieren lässt
      if (int.TryParse(value, out int valueAsInt))
      {
        // Value ist eine Zahl
        if (valueAsInt > 0 && valueAsInt < classNames.Length)
        {
          // User hat eine gültige Zahl eingenehmen
          selectedClass = classNames[valueAsInt];
          Console.WriteLine("You are a " + selectedClass + "!");
        }
        else
        {
          // User hat eine ungültige Zahl eingegeben
          Console.WriteLine("Please enter a number between 0 and " + classNames.Length + "!");
        }
      }
      else
      {
        // Value ist keine Zahl
        Console.WriteLine("Please enter a number.");
      }
      return selectedClass;
    }
  }
}