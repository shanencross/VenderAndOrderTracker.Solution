using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.ModelTests
{
  [TestClass]
  public class VendorTests
  {
    private Vendor testVendor;
    public VendorTests()
    {
      testVendor = new Vendor("Suzie's Cafe", "A happy and cozy little cafe!");
      testOrder1 = new Order("Croissants", "30 boxes of butter croissants", 100.99f, "February 7, 2025");
      testOrder2 = new Order("Baguettes", "15 baguettes", 28.99f, "March 1, 2025");
      testVendor.AddOrder(testOrder1);
      testVendor.AddOrder(testOrder2);
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string expectedName = "Suzie's Cafe";
      Assert.AreEqual(testVendor.Name, expectedName);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string expectedDescription = "A happy and cozy little cafe!";
      Assert.AreEqual(testVendor.Description, expectedDescription);
    }

    [TestMethod]
    public void GetOrders_ReturnsListOfOrders_OrderList()
    {
      Order testOrder1 = new Order("Croissants", "30 boxes of butter croissants", 100.99f, "February 7, 2025");
      Order testOrder2 = new Order("Baguettes", "15 baguettes", 28.99f, "March 1, 2025");    
      List<Order> expectedList = new List<Order> { testOrder1, testOrder2 };

      CollectionAssert.AreEqual(testVendor.Orders, expectedList);
    }


  }
}