using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations;

namespace CoinCombinations.TestTools
{
  [TestClass]
  public class CoinCombinationsTest
  {
    [TestMethod]
    public void InputCheck_InputIsNumber_True()
    {
      CoinCombination testCC = new CoinCombination("5");
      Assert.AreEqual(true, testCC.InputCheck("5"));
    }

    [TestMethod]
    public void InputCheck_InputIsNumber_False()
    {
      CoinCombination testCC = new CoinCombination("5");
      Assert.AreEqual(false, testCC.InputCheck("b"));
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsOnePenny_True()
    {
      CoinCombination testAmount = new CoinCombination("1");
      Assert.AreEqual("1 pennies", testAmount.ReturnCoinTypes());
    }
  }
}
