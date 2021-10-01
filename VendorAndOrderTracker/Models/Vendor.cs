using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{public class Vendor{
public string VendorName {get;set;}
public int Id{get;}

public string Description {get;set;}
private static List<Vendor> _instances = new List<Vendor>{ };

public Vendor(string vendorName, string description)
{
VendorName = vendorName;
Description = description;
_instances.Add(this);
Id=_instances.Count;
}

public static void ClearAll()
{
_instances.Clear();
}
}
}



