using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CoinCombinations.Controllers;
using CoinCombinations.Models;

namespace CoinCombinations.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
       public void Index_ReturnsCorrectView_True()
       {
           //Arrange
           HomeController controller = new HomeController();

           //Act
           IActionResult indexView = controller.Index();
           ViewResult result = indexView as ViewResult;

           //Assert
           Assert.IsInstanceOfType(result, typeof(ViewResult));
       }

       [TestMethod]
       public void Index_HasCorrectModelType_DoubleList()
       {
         //Arrange
         HomeController controller = new HomeController();
         IActionResult actionResult = controller.Index();
         ViewResult indexView = controller.Index() as ViewResult;

         //Act
         var result = indexView.ViewData.Model;

         //Assert
         Assert.AreNotEqual(result, null);
         Assert.IsInstanceOfType(result, typeof(List<double>));
       }
    }
}
