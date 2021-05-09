using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.ModelTests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() {
      // Arrange and Act
      Order newOrder = new Order();

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}