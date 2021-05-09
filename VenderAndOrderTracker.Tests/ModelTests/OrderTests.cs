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
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string expectedTitle = "Croisssants";
      Assert.AreEqual(Order.Title, expectedTitle);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string expectedDescription = "30 boxes of butter croissants";
      Assert.AreEqual(Order.Description, expectedDescription);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      float expectedPrice = 100.99f;
      Assert.AreEqual(Order.Price, expectedPrice);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      float expectedDate = "Feburary 7, 2025";
      Assert.AreEqual(Order.Date, expectedDate);
    }
  }
}