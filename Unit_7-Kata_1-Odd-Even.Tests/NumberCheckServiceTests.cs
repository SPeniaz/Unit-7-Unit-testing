using NUnit.Framework;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Models;
using Unit_7_Kata_1_Odd_Even.NumberProcessing.Services;

namespace Unit_7_Kata_1_Odd_Even.Tests
{
  public class NumberCheckServiceTests
  {
    private NumberCheckService _numberCheckService;
    [SetUp]
    public void Setup()
    {
      _numberCheckService = new NumberCheckService();
    }

    [TestCase(9)]
    [TestCase(15)]
    public void Check_OddNumber_Returns_Odd(int number)
    {
      var result = _numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.Odd);
    }

    [TestCase(4)]
    [TestCase(10)]
    [TestCase(14)]
    [TestCase(16)]
    [TestCase(18)]
    [TestCase(34)]
    public void Check_EvenNumber_Returns_Even(int number)
    {
      var result = _numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.Even);
    }

    [TestCase(3)]
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(13)]
    [TestCase(17)]
    public void Check_PrimeNumber_Returns_Odd_Prime(int number)
    {
      var result = _numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.OddPrime);
    }

    [TestCase(2)]
    public void Check_PrimeNumber_Returns_Even_Prime(int number)
    {
      var result = _numberCheckService.CheckNumber(number);

      Assert.AreEqual(result, NumberType.EvenPrime);
    }
  }
}