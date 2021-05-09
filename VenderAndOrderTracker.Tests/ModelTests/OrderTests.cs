using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.ModelTests
{
  [TestClass]
  public class OrderTests
  {
    private Order testOrder;
    
    public OrderTests()
    {
      testOrder = new Order("Croissants", "30 boxes of butter croissants", 100.99f, "February 7, 2025");
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() 
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string expectedTitle = "Croisssants";
      Assert.AreEqual(testOrder.Title, expectedTitle);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string expectedDescription = "30 boxes of butter croissants";
      Assert.AreEqual(testOrder.Description, expectedDescription);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      float expectedPrice = 100.99f;
      Assert.AreEqual(testOrder.Price, expectedPrice);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string expectedDate = "Feburary 7, 2025";
      Assert.AreEqual(testOrder.Date, expectedDate);
    }
  }
}