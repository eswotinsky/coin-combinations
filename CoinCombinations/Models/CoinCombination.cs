using System;
using System.Text;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class CoinCombination
  {
    private int _userInput;
    // the following 4 must be static in order to reference them in our HomeController, because our HomeController looks at the CoinCombination class as a whole, rather than at a specific instance of CoinCombination
    private double _quarterCount;
    private double _dimeCount;
    private double _nickelCount;
    private double _pennyCount;
    private List<double> _coinCounts = new List<double> {};

    public CoinCombination(string userInput)
    {
      _userInput = int.Parse(userInput);
    }

    public bool InputCheck(string userInput)
    {
      bool UserInputIsNumeric = int.TryParse(userInput, out int a);

      if(UserInputIsNumeric)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string ReturnCoinTypes()
    {
      double leftoverAmount;

      _quarterCount = Math.Floor(System.Convert.ToDouble(_userInput) / 25); //set _quarterCount = the number of times 25 can fit into userInput, rounded down to nearest int
      leftoverAmount = _userInput % 25; //set _leftoverAmount = whatever is left over when _userInput is divided by 25.

      _dimeCount = Math.Floor(leftoverAmount / 10); // divide the leftover amount from the above condition by 10 and if there is anything left over, set that as new leftover amount
      leftoverAmount = leftoverAmount % 10; // new leftover amount

      _nickelCount = Math.Floor(leftoverAmount / 5); //same as above but with nickels
      leftoverAmount = leftoverAmount % 5; // new leftover amount

      _pennyCount = leftoverAmount;

      return _quarterCount + " quarters, " + _dimeCount + " dimes, " + _nickelCount + " nickels, " + _pennyCount + " pennies";
    }

    public List<double> GetCoinCount()
    {
      _coinCounts.Add(_quarterCount);
      _coinCounts.Add(_dimeCount);
      _coinCounts.Add(_nickelCount);
      _coinCounts.Add(_pennyCount);
      return _coinCounts;
    }

  }
}
