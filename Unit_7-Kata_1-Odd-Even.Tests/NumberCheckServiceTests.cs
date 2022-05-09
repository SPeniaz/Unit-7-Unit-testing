using NUnit.Framework;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Models;

namespace Unit_7_Kata_1_Odd_Even.Tests
{
  public class NumberCheckServiceTests
  {
    private readonly NumberCheckService _numberCheckService;
    [SetUp]
    public void Setup()
    {
      _numberCheckService = new NumberCheckService();
    }

    [TestCase(3)]
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(9)]
    [TestCase(11)]
    [TestCase(29)]
    [TestCase(33)]
    [TestCase(59)]
    public void Check_OddNumber_Returns_Odd()
    {
      var result = numberCheckService.CheckNumber(oddNumber);

      Assert.AreEqual(result, NumberType.Odd);
    }

    [TestCase(2)]
    [TestCase(4)]
    [TestCase(10)]
    [TestCase(14)]
    [TestCase(16)]
    [TestCase(18)]
    [TestCase(34)]
    public void Check_EvenNumber_Returns_Even(int number)
    {
      var result = numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.Even);
    }

    [TestCase(2)]
    [TestCase(3)]
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(13)]
    [TestCase(17)]
    public void Check_PrimeNumber_Returns_Prime(int number)
    {
      var result = numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.Prime);
    }
  }
}