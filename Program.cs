using System;
using System.Reflection;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("What do you want to do?");
      Console.WriteLine("0 - Sum");
      Console.WriteLine("1 - Subtraction");
      Console.WriteLine("2 - Multiplication");
      Console.WriteLine("3 - Division");
      Console.WriteLine("4 - Exit");
      Console.WriteLine("--------------------");
      Console.WriteLine("Select an option: ");
      string? input = Console.ReadLine();
      if (EOperation.TryParse(input, out EOperation res))
      {
        //Switch case
        switch (res)
        {
          case EOperation.Sum:
            Sum();
            break;
          case EOperation.Subtraction:
            Subtraction();
            break;
          case EOperation.Multiplication:
            Multiplication();
            break;
          case EOperation.Division:
            Division();
            break;
          case EOperation.Exit:
            System.Environment.Exit(0);
            break;
          default:
            Menu();
            break;
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a number.");
        Menu();
      }
    }

    enum EOperation
    {
      Sum,
      Subtraction,
      Multiplication,
      Division,
      Exit
    }

    static void Sum()
    {
      Console.Clear();
      Console.WriteLine("First value: ");
      string? input1 = Console.ReadLine();
      Console.WriteLine("Second value: ");
      string? input2 = Console.ReadLine();
      Console.WriteLine("");

      if (float.TryParse(input1, out float v1) && float.TryParse(input2, out float v2))
      {
        Console.WriteLine("The result of the sum is: " + (v1 + v2) + "\n");
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
      }
      Menu();
    }

    static void Subtraction()
    {
      Console.Clear();
      Console.WriteLine("First value: ");
      string? input1 = Console.ReadLine();
      Console.WriteLine("Second value: ");
      string? input2 = Console.ReadLine();
      Console.WriteLine("");

      if (float.TryParse(input1, out float v1) && float.TryParse(input2, out float v2))
      {
        Console.WriteLine("The result of the subtraction is: " + (v1 - v2));
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
      }
      Menu();
    }

    static void Multiplication()
    {
      Console.Clear();
      Console.WriteLine("First value: ");
      string? input1 = Console.ReadLine();
      Console.WriteLine("Second value: ");
      string? input2 = Console.ReadLine();
      Console.WriteLine("");

      if (float.TryParse(input1, out float v1) && float.TryParse(input2, out float v2))
      {
        Console.WriteLine("The result of the multiplication is: " + (v1 * v2));
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
      }
      Menu();
    }

    static void Division()
    {
      Console.Clear();
      Console.WriteLine("First value: ");
      string? input1 = Console.ReadLine();
      Console.WriteLine("Second value: ");
      string? input2 = Console.ReadLine();
      Console.WriteLine("");

      if (float.TryParse(input1, out float v1) && float.TryParse(input2, out float v2))
      {
        if (v2 != 0)
        {
          Console.WriteLine("The result of the division is: " + (v1 / v2));
          Console.WriteLine("Press any key to return to the menu.");
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Cannot divide by zero.");
          Console.WriteLine("Press any key to return to the menu.");
          Console.ReadKey();
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
      }
      Menu();
    }
  }
}