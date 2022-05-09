using System;

namespace Unit_7_Kata_1_Odd_Even.NumberProcessing.Models
{
  public class ProcessedNumber
  {
    public int Number { get; private set; }
    public string Properties { get; private set; }

    public ProcessedNumber(int number, string properties)
    {
      this.Number = number;
      this.Properties = properties;
    }
  }
}
