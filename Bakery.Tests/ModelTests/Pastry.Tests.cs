using Bakery.Models;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.UserInterfaceModels;

namespace Bakery.Tests
{
  [TestClass]
  public class UnitTest2
  {
    [TestMethod]
    public void ConstructorCheck_CheckIfPastryOrderInstanceExists_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PriceCheck_CheckIfPriceCalcWorksPastry_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.QuantityPastry = 1;
      Assert.AreEqual(newPastry.CalculateCostPastry(), 4);

    }
    [TestMethod]
    public void DiscountCheck_CheckIfPriceCalcWorksWithDiscount_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.QuantityPastry = 3;
      Assert.AreEqual(newPastry.CalculateCostPastry(), 8);

    }
  }
}
