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
    [TestMethod]
    public void GetBreadPriceTotal_ReturnsBreadPriceTotal_Int()
    {
      // Test 13: Test the GetBreadTotal() method
      
      Bread newBread = new Bread(3);
      int result = newBread.BreadPriceTotal;
      Assert.AreEqual(10, result);
    }
  } 
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      // Test 7: Test the Pastry constructor
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastry_GetsPastryOrder_Int()
    {
      // Test 8 Test getPastry
      int pastryOrder = 1;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry.PastryOrder;
      Assert.AreEqual(pastryOrder, result);
    }
    [TestMethod]
    public void SetPastry_SetsPastryOrder_Void()
    {
      // Test 9 Test setPastry
  
      Pastry newPastry = new Pastry(1);
      int updatedPastryOrder = 2;
      newPastry.PastryOrder = updatedPastryOrder;
      int result = newPastry.PastryOrder;
      Assert.AreEqual(updatedPastryOrder, result);
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      // Test 10 Test
      int pastryOrder = 1;
      Pastry newPastry = new Pastry(pastryOrder); 
      int result = newPastry.GetPastryPrice(pastryOrder);
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscountDivisbleBy4_Int()
    {
      // Test 11
      int pastryOrder = 4;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry.GetPastryPrice(pastryOrder);
      Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscountNotDivisibleBy4_Int2()
    {
      // Test 12
      int pastryOrder = 33;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry.GetPastryPrice(pastryOrder);
      Assert.AreEqual(52, result);
    }
    [TestMethod]
    public void GetPastryPriceTotal_ReturnsPastryPriceTotal_Int()
    {
      // Test 14
      Pastry newPastry = new Pastry(4);
      int result = newPastry.PastryPriceTotal;
      Assert.AreEqual(6, result);
    }
  }
}