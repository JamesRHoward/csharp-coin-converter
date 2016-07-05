using Xunit;
using System.Collections.Generic;

namespace Coin
{
  public class CoinTest
  {
    [Fact]
    public void CalculateChange_ForAmountDivisibleByWholeDollar_NoCoins()
    {
      CalculateChange testCalculateChange = new CalculateChange();
      Dictionary<string, int> testDictionary = new Dictionary<string, int>();
      testDictionary.Add("quarters", 0);
      testDictionary.Add("dimes", 0);
      testDictionary.Add("nickels", 0);
      testDictionary.Add("pennies", 0);
      Assert.Equal(testDictionary, testCalculateChange.ReturnCoins(12));
    }


  }
}
