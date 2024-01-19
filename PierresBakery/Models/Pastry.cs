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
  }
}

