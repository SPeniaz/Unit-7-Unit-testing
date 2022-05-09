using System;
using System.Collections.Generic;
using System.Text;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Models;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Services;

namespace Unit_7_Kata_1_Odd_Even.NumberProcessing
{
  public static class NumberCheckProcessor
  {
    public static List<ProcessedNumber> ProcessNumbers(int startIndex, int endIndex)
    {
      var result = new List<ProcessedNumber>();
      var numberCheckService = new NumberCheckService();

      for (int i = startIndex; i <= endIndex; i++)
      {
        var checkResult = numberCheckService.CheckNumber(i);
        result.Add(new ProcessedNumber(i, checkResult.GetString()));
      }

      return result;
    }
  }
}
