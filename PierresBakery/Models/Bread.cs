using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; }

    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
  }
}