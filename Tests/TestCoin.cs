using Xunit;
using System.Collections.Generic;

namespace Coin
{
  public class CoinTest
  {
    // [Fact]
    // public void CalculateChange_ForAmountDivisibleByWholeDollar_NoCoins()
    // {
    //   CalculateChange testCalculateChange = new CalculateChange();
    //   Dictionary<string, int> testDictionary = new Dictionary<string, int>();
    //   testDictionary.Add("quarters", 0);
    //   testDictionary.Add("dimes", 0);
    //   testDictionary.Add("nickels", 0);
    //   testDictionary.Add("pennies", 0);
    //   Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(12));
    // }
    //
    // [Fact]
    // public void CalculateChange_ForRemainingAmountDivisibleBy25Cents_Quarters()
    // {
    //   CalculateChange testCalculateChange = new CalculateChange();
    //   Dictionary<string, int> testDictionary = new Dictionary<string, int>();
    //   testDictionary.Add("quarters", 3);
    //   testDictionary.Add("dimes", 0);
    //   testDictionary.Add("nickels", 0);
    //   testDictionary.Add("pennies", 0);
    //   Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(0.75));
    // }

    // [Fact]
    // public void CalculateChange_ForRemainingAmountDivisibleBy10Cents_Dimes()
    // {
    //   CalculateChange testCalculateChange = new CalculateChange();
    //   Dictionary<string, int> testDictionary = new Dictionary<string, int>();
    //   testDictionary.Add("quarters", 3);
    //   testDictionary.Add("dimes", 2);
    //   testDictionary.Add("nickels", 0);
    //   testDictionary.Add("pennies", 0);
    //   Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(0.95));
    // }

    // [Fact]
    // public void CalculateChange_ForRemainingAmountDivisibleBy5Cents_Nickel()
    // {
    //   CalculateChange testCalculateChange = new CalculateChange();
    //   Dictionary<string, int> testDictionary = new Dictionary<string, int>();
    //   testDictionary.Add("quarters", 2);
    //   testDictionary.Add("dimes", 0);
    //   testDictionary.Add("nickels", 1);
    //   testDictionary.Add("pennies", 0);
    //   Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(0.55));
    // }

    [Fact]
    public void CalculateChange_ForRemainingAmountDivisibleBy5Cents_Nickel()
    {
      CalculateChange testCalculateChange = new CalculateChange();
      Dictionary<string, int> testDictionary = new Dictionary<string, int>();
      testDictionary.Add("quarters", 2);
      testDictionary.Add("dimes", 0);
      testDictionary.Add("nickels", 1);
      testDictionary.Add("pennies", 4);
      Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(0.59));
    }

  }
}
