using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests

{

  [TestClass]
  // public class VendorTests
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }


    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testName", "testDescript");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());

    }
    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      Vendor newVendor = new Vendor("testName", "testDescript");
      string name = "testName";
      string result = newVendor.VendorName;
      Assert.AreEqual(result, name);

    }
    [TestMethod]
    public void GetVendorName_ReturnsDescription_String()
    {
      Vendor newVendor = new Vendor("testName", "testDescript");
      string description = "testDescript";
      string result = newVendor.Description;
      Assert.AreEqual(result, description);

    }
 [TestMethod]
    public void SetName_SetName_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedDescript = "updatedDescript";
      newVendor.Description = updatedDescript;
      string result = newVendor.Description;
      Assert.AreEqual(result,updatedDescript);
    }
[TestMethod]
    public void SetDescription_SetSetDescription_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedDescript = "updatedDescript";
      newVendor.Description = updatedDescript;
      string result = newVendor.Description;
      Assert.AreEqual(result,updatedDescript);
    }
  }
}





