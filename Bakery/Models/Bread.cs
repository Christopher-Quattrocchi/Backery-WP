using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Bakery.Models
{
  public class Bread
  {
    public int QuantityBread { get; set; }
    private int BreadPrice = 5;

    public int CalculateCostBread()
    {
      int howManySets = QuantityBread / 3;
      int remainingLoaves = QuantityBread % 3;
      
      return (howManySets * 2 * BreadPrice) + (remainingLoaves * BreadPrice);
    }
  }
}