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
  }
}