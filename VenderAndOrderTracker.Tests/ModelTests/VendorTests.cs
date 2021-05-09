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
      Order testOrder1 = new Order("Croissants", "30 boxes of butter croissants", 100.99f, "February 7, 2025");
      Order testOrder2 = new Order("Baguettes", "15 baguettes", 28.99f, "March 1, 2025");
      testVendor.AddOrder(testOrder1);
      testVendor.AddOrder(testOrder2);
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() 
    {
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
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
      List<Order> expectedList2 = new List<Order> { testOrder1, testOrder2 };

      for (int i=0; i<testVendor.Orders.Count; i++)
      {
        Order order = testVendor.Orders[i];
        Order expectedOrder = expectedList[i];
        Assert.AreEqual(order.Title, expectedOrder.Title);
        Assert.AreEqual(order.Description, expectedOrder.Description);
        Assert.AreEqual(order.Price, expectedOrder.Price);
        Assert.AreEqual(order.Date, expectedOrder.Date);
      }
    }


  }
}