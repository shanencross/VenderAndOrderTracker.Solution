using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.ModelTests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    private Vendor testVendor;
    
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
      string result = testVendor.Name;
      Assert.AreEqual(expectedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string expectedDescription = "A happy and cozy little cafe!";
      string result = testVendor.Description;
      Assert.AreEqual(expectedDescription, testVendor.Description);
    }

    [TestMethod]
    public void GetOrders_ReturnsListOfOrders_OrderList()
    {
      Order testOrder1 = new Order("Croissants", "30 boxes of butter croissants", 100.99f, "February 7, 2025");
      Order testOrder2 = new Order("Baguettes", "15 baguettes", 28.99f, "March 1, 2025");
      List<Order> expectedList = new List<Order> { testOrder1, testOrder2 };
      
      for (int i=0; i<testVendor.Orders.Count; i++)
      {
        Order order = testVendor.Orders[i];
        Order expectedOrder = expectedList[i];

        Assert.AreEqual(expectedOrder.Title, order.Title);
        Assert.AreEqual(expectedOrder.Description, order.Description);
        Assert.AreEqual(expectedOrder.Price, order.Price);
        Assert.AreEqual(expectedOrder.Date, order.Date);
      }
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorWithCorrectId_Vendor()
    {
      Vendor otherTestVendor = new Vendor("Bob's Bread Stand", "A convenient little outdoor bread stand!");
      Order testOrder1 = new Order("Sourdough", "12 bags of sourdough bread", 50.99f, "February 3, 2025");
      Order testOrder2 = new Order("Ciabatta", "20 bags of ciabatta bread", 28.99f, "March 3, 2025");
      otherTestVendor.AddOrder(testOrder1);
      otherTestVendor.AddOrder(testOrder2);
      
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(otherTestVendor, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
    {
      Vendor otherTestVendor = new Vendor("Bob's Bread Stand", "A convenient little outdoor bread stand!");
      Order testOrder1 = new Order("Sourdough", "12 bags of sourdough bread", 50.99f, "February 3, 2025");
      Order testOrder2 = new Order("Ciabatta", "20 bags of ciabatta bread", 28.99f, "March 3, 2025");
      otherTestVendor.AddOrder(testOrder1);
      otherTestVendor.AddOrder(testOrder2);

      List<Vendor> expectedVendorList = new List<Vendor> { testVendor, otherTestVendor };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(expectedVendorList, result);
    }

    [TestMethod]
    public void ClearAll_EmptiesListOfVendorInstances_VendorList()
    {
      Vendor otherTestVendor = new Vendor("Bob's Bread Stand", "A convenient little outdoor bread stand!");
      Order testOrder1 = new Order("Sourdough", "12 bags of sourdough bread", 50.99f, "February 3, 2025");
      Order testOrder2 = new Order("Ciabatta", "20 bags of ciabatta bread", 28.99f, "March 3, 2025");
      otherTestVendor.AddOrder(testOrder1);
      otherTestVendor.AddOrder(testOrder2);
      List<Vendor> expectedVendorList = new List<Vendor>();
      Vendor.ClearAll();
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(expectedVendorList, result);
    }
  }
}