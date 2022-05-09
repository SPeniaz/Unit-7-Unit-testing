using System;
using System.Collections.Generic;
using System.Text;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Models;

namespace Unit_7_Kata_1_Odd_Even.NumberProcessing.Services
{
  public class NumberCheckService
  {
    public NumberType CheckNumber(int number)
    {
      if (IsPositive(number))
      {
        if (number == 2)
        {
          return NumberType.EvenPrime;
        }
        if (IsOdd(number))
        {
          if (IsPrime(number))
          {
            return NumberType.OddPrime;
          }
          return NumberType.Odd;
        }
        return NumberType.Even;
      }
      return NumberType.Incorrect;
    }

    #region Private methods

    private bool IsPositive (int number)
    {
      return number > 0 == true;
    }

    private bool IsOdd (int number)
    {
      return number % 2 == 1;
    }

    private bool IsEven (int number)
    {
      return !IsOdd(number);
    }

    private bool IsPrime(int number)
    {
      if (number <= 1) return false;
      if (number == 2) return true;
      if (number % 2 == 0) return false;

      var boundary = (int)Math.Floor(Math.Sqrt(number));

      for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
          return false;

      return true;
    }
    #endregion
  }
}
