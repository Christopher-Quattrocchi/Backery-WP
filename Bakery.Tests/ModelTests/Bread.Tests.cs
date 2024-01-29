using Bakery.Models;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.UserInterfaceModels;

namespace Bakery.Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void ConstructorCheck_CheckIfOrderInstanceExists_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PriceCheck_CheckIfPriceCalcWorks_Int()
    {
      Bread newBread = new Bread();
      newBread.QuantityBread = 1;
      Assert.AreEqual(newBread.CalculateCostBread(), 5);

    }
    [TestMethod]
    public void DiscountCheck_CheckIfPriceCalcWorksWithDiscount_Int()
    {
      Bread newBread = new Bread();
      newBread.QuantityBread = 3;
      Assert.AreEqual(newBread.CalculateCostBread(), 10);

    }
  }

}

