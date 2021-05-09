using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders { get; } = new List<Order>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}