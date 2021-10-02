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
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      Order newOrder = new Order("testtitle", "testDescription", 0, "testdate");
      string updatedTitle = "updatedTitle";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(result, updatedTitle);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string Title1 = "order1";
      string description1 = "orderdescript1";
      string Title2 = "order2";
      string description2 = "order01descript2";
      Order newOrder1 = new Order(Title1, description1, 0, "testDate");
      Order newOrder2 = new Order(Title2, description2, 0, "testDate");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}





