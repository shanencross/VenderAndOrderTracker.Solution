using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders { get; } = new List<Order>();

    private static List<Vendor> _instances = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static Vendor Find(int id)
    {
      return _instances[id-1];
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