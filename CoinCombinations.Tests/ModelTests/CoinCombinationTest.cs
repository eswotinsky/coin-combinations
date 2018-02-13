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
    public void ReturnCoinTypes_InputIsOneCent_True()
    {
      CoinCombination testAmount = new CoinCombination("1");
      Assert.AreEqual("0 quarters, 0 dimes, 0 nickels, 1 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod] //this will break soon. will need to update
    public void ReturnCoinTypes_InputIsEightCents_True()
    {
      CoinCombination testAmount = new CoinCombination("8");
      Assert.AreEqual("0 quarters, 0 dimes, 1 nickels, 3 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsFiveCents_True()
    {
      CoinCombination testAmount = new CoinCombination("5");
      Assert.AreEqual("0 quarters, 0 dimes, 1 nickels, 0 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsTenCents_True()
    {
      CoinCombination testAmount = new CoinCombination("10");
      Assert.AreEqual("0 quarters, 1 dimes, 0 nickels, 0 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsTwentyCents_True()
    {
      CoinCombination testAmount = new CoinCombination("20");
      Assert.AreEqual("0 quarters, 2 dimes, 0 nickels, 0 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsTwentyThreeCents_True()
    {
      CoinCombination testAmount = new CoinCombination("23");
      Assert.AreEqual("0 quarters, 2 dimes, 0 nickels, 3 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsTwentyFiveCents_True()
    {
      CoinCombination testAmount = new CoinCombination("25");
      Assert.AreEqual("1 quarters, 0 dimes, 0 nickels, 0 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsFiftyCents_True()
    {
      CoinCombination testAmount = new CoinCombination("50");
      Assert.AreEqual("2 quarters, 0 dimes, 0 nickels, 0 pennies", testAmount.ReturnCoinTypes());
    }

    [TestMethod]
    public void ReturnCoinTypes_InputIsFiftyNineCents_True()
    {
      CoinCombination testAmount = new CoinCombination("59");
      Assert.AreEqual("2 quarters, 0 dimes, 1 nickels, 4 pennies", testAmount.ReturnCoinTypes());
    }

  }
}
