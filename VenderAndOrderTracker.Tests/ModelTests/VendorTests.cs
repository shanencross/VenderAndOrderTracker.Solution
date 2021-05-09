using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.ModelTests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() {
      // Arrange and Act
      Vendor newVendor = new Vendor();

      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }


  }
}