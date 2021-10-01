using System.Collections.Generic;
namespace VendorAndOrderTracker.Models


{
  public class Order

  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }
    public bool IsClosed { get; set; }

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
      IsClosed = false;

    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
 
        public static List<Order> GetAll()
        {
          return _instances;
        }
      }
    }

