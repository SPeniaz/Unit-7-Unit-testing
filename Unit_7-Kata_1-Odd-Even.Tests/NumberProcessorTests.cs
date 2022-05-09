using NUnit.Framework;
using System.Collections.Generic;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Models;

namespace Unit_7_Kata_1_Odd_Even.Tests
{
  class NumberProcessorTests
  {
    [TestCase(1, 4, ExpectedResult = 4)]
    [TestCase(1, 100, ExpectedResult = 100)]
    [TestCase(1, 200, ExpectedResult = 200)]
    public void Process_Numbers_Returns_Correct_Length(int startIndex, int endIndex)
    {
      return numberCheckService.ProcessNumbers(startIndex, endIndex).Count;
    }

    [Test]
    public void Process_Numbers_1_10_Returns_Correct_Result()
    {
      var expected = new List<ProcessedNumber>()
      {
        new ProcessedNumber(1, "Odd"),
        new ProcessedNumber(2, "Even, Prime"),
        new ProcessedNumber(3, "Odd, Prime"),
        new ProcessedNumber(4, "Even"),
        new ProcessedNumber(5, "Odd, Prime"),
        new ProcessedNumber(6, "Even"),
        new ProcessedNumber(7, "Odd, Prime"),
        new ProcessedNumber(8, "Even"),
        new ProcessedNumber(9, "Odd"),
        new ProcessedNumber(10, "Even")
      };

      var result = numberCheckService.ProcessNumbers(1, 10);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Process_Wrong_Numbers_Returns_Result_With_Remarks()
    {
      var expected = new List<ProcessedNumber>
      {
         new ProcessedNumber(-1, "Incorrect number"),
         new ProcessedNumber(0, "Incorrect number"),
      };

      var result = numberCheckService.ProcessNumbers(-1, 0);

      Assert.AreEqual(expected, result);
    }
  }
}
