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
    [TestMethod]
    public void SetBread_ReturnsBread_Void()
    {
      Bread newBread = new Bread(1);
      int updatedBreadOrder = 2;
      newBread.BreadOrder = updatedBreadOrder;
      int result = newBread.BreadOrder;
      Assert.AreEqual(updatedBreadOrder, result);
    }
    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      int breadOrder = 1;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.GetBreadPrice(breadOrder);
      Assert.AreEqual(5, result);
    }
  } 
}