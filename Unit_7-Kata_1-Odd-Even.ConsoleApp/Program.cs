using System;
using Unit_7_Kata_1_Odd_Even.NumberProcessing;

namespace Unit_7_Kata_1_Odd_Even.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {

      int startIndex = 0, endIndex = 0;

      while (true)
      {
        Console.WriteLine("Please enter a start index");
        try
        {
          startIndex = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Incorrect value");
          continue;
        }
        Console.WriteLine("Please enter a end index");
        try
        {
          endIndex = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Incorrect value");
          continue;
        }
        if (startIndex > endIndex)
        {
          Console.WriteLine("Start index should be greater then end index");
          continue;
        }
        foreach (var item in NumberCheckProcessor.ProcessNumbers(startIndex, endIndex))
        {
          Console.WriteLine($"{item.Number}, {item.Properties}");
          
        }

        Console.WriteLine();
        Console.WriteLine("Press 'C' to continue");
        if (Console.ReadLine().ToLower() == "c")
        {
          continue;
        }
        break;
      }


    }
  }
}
