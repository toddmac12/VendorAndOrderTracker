using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Orders { get; set; }
    public string VendorName { get; set; }
    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()

    {
      _instances.Clear();
    }
    public static Vendor Find(int searchID)
    {
      return _instances[searchID - 1];

    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}



