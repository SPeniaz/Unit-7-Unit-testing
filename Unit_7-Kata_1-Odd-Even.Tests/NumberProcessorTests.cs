using NUnit.Framework;
using System.Collections.Generic;

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
      var expected = new List<ProcessedNumber>
      {
        {1, "Odd" },
        {2, "Even, Prime" },
        {3, "Odd, Prime" },
        {4, "Even" },
        {5, "Odd, Prime" },
        {6, "Even" },
        {7, "Odd, Prime" },
        {8, "Even" },
        {9, "Odd" },
        {10, "Even" }
      };

      var result = numberCheckService.ProcessNumbers(1, 10);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Process_Wrong_Numbers_Returns_Result_With_Remarks()
    {
      var expected = new List<ProcessedNumber>
      {
        {-1, "Incorrect number" },
        {0, "Incorrect number" },
      };

      var result = numberCheckService.ProcessNumbers(-1, 0);

      Assert.AreEqual(expected, result);
    }
  }
}
