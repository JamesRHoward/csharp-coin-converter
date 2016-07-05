using System.Collections.Generic;

namespace Coin
{
  public class CalculateChange
  {
    public Dictionary<string, int> ReturnCoins(double changeTotal)
    {
      Dictionary<string, int> changeDictionary = new Dictionary<string, int>();
      changeDictionary.Add("quarters", 0);
      changeDictionary.Add("dimes", 0);
      changeDictionary.Add("nickels", 0);
      changeDictionary.Add("pennies", 0);
      if ( changeTotal % 1 == 0) {
        return changeDictionary;
      } else {
        System.Console.WriteLine("You have failed");
        return changeDictionary;
      }
    }
  }
}
