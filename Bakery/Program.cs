using System;
using Bakery.Models;
using System.Collections.Generic;
using Bakery.UserInterfaceModels;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine("Welcome to Zelena's Bakery!");
      Console.WriteLine("We offer bread and pastries, at five and four dollars respectively.");
      Console.WriteLine("Every third loaf of bread or pastry is free, but you can't mix and match freebies.");

      Console.WriteLine("How many loaves of bread would you like?");
      int breadCount = ReadIntInput();
      Bread breadOrder = new Bread { QuantityBread = breadCount };

      Console.WriteLine("How many pastries would you like?");
      int pastryCount = ReadIntInput();
      Pastry pastryOrder = new Pastry { QuantityPastry = pastryCount };

      int totalCost = breadOrder.CalculateCostBread() + pastryOrder.CalculateCostPastry();
      Console.WriteLine($"The total cost of your order is: ${totalCost}");

    }

    private static int ReadIntInput()
    {
      while (true)
      {
        if (int.TryParse(Console.ReadLine(), out int input) && input >= 0)
        {
          return input;
        }
        else
        {
          Console.WriteLine("Please enter a number.");
        }
      }
    }
  }
}