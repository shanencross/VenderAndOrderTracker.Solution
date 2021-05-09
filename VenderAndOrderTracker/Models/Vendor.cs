using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders { get; } = new List<Order>();

    private static List<Vendor> _instances = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}