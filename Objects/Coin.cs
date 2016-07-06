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
      int runningRemainingTotal = Convert.ToInt32(changeTotal * 100);
      if (changeTotal % 1 == 0) {
        return changeDictionary;
      }
      else {
        changeDictionary["quarters"] = runningRemainingTotal/25;
        runningRemainingTotal = runningRemainingTotal % 25;
        this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
        changeDictionary["dimes"] = runningRemainingTotal/10;
        runningRemainingTotal = runningRemainingTotal % 10;
        this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
        changeDictionary["nickels"] = runningRemainingTotal/5;
        runningRemainingTotal = runningRemainingTotal % 5;
        this.PrintCoinAmounts(changeDictionary, runningRemainingTotal);
        return changeDictionary;
        }
    }
    public void PrintCoinAmounts(Dictionary<string, int> currentCoins, double runningTotal)
    {
      Console.WriteLine(currentCoins["quarters"] + " " + currentCoins["dimes"] + " " + currentCoins["nickels"] + " " + currentCoins["pennies"] + " and " + runningTotal + " remaining");
    }
  }
}
