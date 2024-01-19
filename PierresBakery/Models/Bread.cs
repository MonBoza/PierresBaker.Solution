using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }

    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
    public int GetBreadPrice(int BreadOrder)
    {
      int breadPrice = 5;
       if (BreadOrder % 3 == 0)
      {
        // if order is divisible by 3, subtract 5 from every third loaf
        breadPrice = (breadPrice * BreadOrder) - ((BreadOrder / 3) * 5);
      }
      else if (BreadOrder % 3 != 0)
      breadPrice = BreadOrder* 5;
      return breadPrice;
    }
  }
}