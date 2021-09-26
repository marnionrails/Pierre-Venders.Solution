using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVendors.Models;
using System;

namespace PierreVendors.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}