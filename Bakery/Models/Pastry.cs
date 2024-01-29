using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Bakery.Models
{
  public class Pastry
  {
    public int QuantityPastry { get; set; }
    private int PastryPrice = 4;

    public int CalculateCostPastry()
    {
      int howManySets = QuantityPastry / 3;
      int remainingPastries = QuantityPastry % 3;
      
      return (howManySets * 2 * PastryPrice) + (remainingPastries * PastryPrice);
    }
  }
}