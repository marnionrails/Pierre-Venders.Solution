using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVendors.Models;
using System;

namespace PierreVendors.Tests
{
  [TestClass]
  public class VendorTests :IDisposable
  {

    public void Dispose()
    {

    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    /* [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Marni's Bakery";
      Vendor newVendor = new Vendor(name);
      string updatedName = "new Name";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    } */
  }
}