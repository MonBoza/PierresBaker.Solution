using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrder {get; set;}
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
    public int GetPastryPrice(int pastryOrder)
    {
      int pastryPrice = 2;
      return pastryPrice;
    }
  }
}

