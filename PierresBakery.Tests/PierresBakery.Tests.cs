using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

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
      // Test 4: Test the GetBreadPrice() method
      int breadOrder = 1;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.GetBreadPrice(breadOrder);
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount_Int()
    {
      // Test 5: Test the GetBreadPrice() method with discount I forgot to commit this test
      int breadOrder = 3;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.GetBreadPrice(breadOrder);
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount_Int2()
    {
      // Test 6: Test the GetBreadPrice() method with discount edge case
      int breadOrder = 26;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.GetBreadPrice(breadOrder);
      Assert.AreEqual(100, result);
    }
    
  } 
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}