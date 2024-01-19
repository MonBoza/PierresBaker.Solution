using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBread_ReturnsBread_Int()
    {
      int breadOrder = 1;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.BreadOrder;
      Assert.AreEqual(breadOrder, result);
    }
  }
}