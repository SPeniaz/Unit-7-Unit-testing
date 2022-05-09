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

    public override bool Equals(object obj)
    {
      // Check for null values and compare run-time types.
      if (obj == null || GetType() != obj.GetType())
        return false;

      ProcessedNumber p = (ProcessedNumber)obj;
      return (Number == p.Number) && (Properties == p.Properties);

    }

    public override int GetHashCode()
    {
      return Number ^ 3;
    }
  }
}
