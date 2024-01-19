using System;
using PierresBakery.Models;
using PierresBakery.UserInterfaceModels;
using System.Collections.Generic;


namespace PierresBakery.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(PierresBakery.UserInterfaceModels.WelcomeBanner.Welcome);
      Console.WriteLine("Welcome to Pierre's Bakery!\n");
      NavigateMenu();
    }

    static void NavigateMenu()
    {
      Console.WriteLine("Would you like to order bread or pastries? Both? (Bread/Pastries/Both/Exit)");
      string userInput = Console.ReadLine().ToLower();
      if (userInput == "bread")
      {
        Console.WriteLine("How many loaves of bread would you like to order?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadOrder);
        Console.WriteLine("Your total is $" + newBread.BreadPriceTotal + "\n");
        NavigateMenu();
      }
      else if (userInput == "pastries")
      {
        Console.WriteLine("How many pastries would you like to order?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry newPastry = new Pastry(pastryOrder);
        Console.WriteLine("Your total is $" + newPastry.PastryPriceTotal + "\n");
        NavigateMenu();
      }
      else if (userInput == "both")
      {
        Console.WriteLine("How many loaves of bread would you like to order?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadOrder);
        Console.WriteLine("How many pastries would you like to order?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry newPastry = new Pastry(pastryOrder);
        Console.WriteLine("Your total is $" + (newBread.BreadPriceTotal + newPastry.PastryPriceTotal) + "\n");
        Console.WriteLine("Does that complete your order? (Yes/No)");
        string userInput2 = Console.ReadLine().ToLower();
        if (userInput2 == "yes")
        {
          Console.WriteLine("Thank you for visiting Pierre's bakery!\n");
        }
        else if (userInput2 == "no")
        {
          // need to work on grandtotal
          NavigateMenu();
        }
        else {
          Console.WriteLine("Please enter a valid input.");
          NavigateMenu();
        }
      }
      else if (userInput == "exit")
      {
        Console.WriteLine("Thank You for visiting Pierre's Bakery!\n");
      }
      else
      {
        Console.WriteLine("Please enter a valid input.\n");
        NavigateMenu();
      }
    }
   
  }
}