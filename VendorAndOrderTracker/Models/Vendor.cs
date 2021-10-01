using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public int Id { get; }

    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName, string description)
    {
      VendorName = vendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchID)
    {
      return _instances[searchID - 1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}



