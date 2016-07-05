using System;
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
      double runningRemainingTotal = changeTotal;
      this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
      if (changeTotal % 1 == 0) {
        return changeDictionary;
      }
      changeDictionary["quarters"] = Convert.ToInt32(Math.Floor(runningRemainingTotal/0.25));
      runningRemainingTotal = runningRemainingTotal % 0.25;
      this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
      changeDictionary["dimes"] = Convert.ToInt32(Math.Ceiling(runningRemainingTotal/0.10));
      runningRemainingTotal = runningRemainingTotal % 0.10;
      this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
      return changeDictionary;
    }
    public void PrintCoinAmounts(Dictionary<string, int> currentCoins, double runningTotal)
    {
      Console.WriteLine(currentCoins["quarters"] + " " + currentCoins["dimes"] + " " + currentCoins["nickels"] + " " + currentCoins["pennies"] + " and " + runningTotal + " remaining");
    }
  }
}
