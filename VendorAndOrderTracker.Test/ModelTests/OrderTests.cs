using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests.ModelTests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]

    public void GetTitle_ReturnsTitle_String()
    {
      Order newOrder = new Order("title", "description", 0, "date");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]

    public void GetDescription_ReturnsDescription_String()
    {
      Order newOrder = new Order("testtitle", "testDescription", 0, "testdate");
      string description = "testDescription";
      string result = newOrder.Description;
      Assert.AreEqual(result, description);
    }

  }
}





