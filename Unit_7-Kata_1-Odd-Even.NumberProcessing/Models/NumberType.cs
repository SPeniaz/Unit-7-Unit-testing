using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_7_Kata_1_Odd_Even.NumberProcessing.Models
{
  public enum NumberType
  {
    Odd,
    Even,
    OddPrime,
    EvenPrime,
    Incorrect
  }

  public static class ErrorLevelExtensions
  {
    public static string GetString(this NumberType me)
    {
      switch (me)
      {
        case NumberType.Odd:
          return "Odd";
        case NumberType.Even:
          return "Even";
        case NumberType.OddPrime:
          return "Odd, Prime";
        case NumberType.EvenPrime:
          return "Even, Prime";
        case NumberType.Incorrect:
          return "Incorrect number";
        default:
          return "NO VALUE GIVEN";
      }
    }
  }
}
