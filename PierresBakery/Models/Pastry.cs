using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrder {get; set;}
    public  int PastryPriceTotal => GetPastryPrice(PastryOrder);
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
    public int GetPastryPrice(int pastryOrder)
    {
      int pastryPrice = 2;

       if (pastryOrder % 4 == 0)
     {
      pastryPrice = (pastryPrice * pastryOrder) - ((pastryOrder / 4) * 2);
     }
     else if (pastryOrder % 4 != 0 && pastryOrder > 4)
     {
      pastryPrice = (pastryPrice * pastryOrder) - ((pastryOrder / 4) * 2) + (pastryOrder % 4 * 2);
      // pastry price times pastry Order minus the pastry order divided by 4 times 2 plus remainder of the order times 2
     }
     else{
      pastryPrice = pastryPrice * pastryOrder;
     }
     return pastryPrice;
    }
  }
}

