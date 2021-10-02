using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
public class VendorsController: Controller

{
[HttpGet("/vendors")]
public ActionResult Index()
{
List<Vendor> allVendors = Vendor.GetAll();
return View(allVendors);
}


[HttpGet("/vendors/new")]
public ActionResult New()
{
return View();
}


[HttpPost("/vendors")]
public ActionResult Create(string name, string description)
{
Vendor myVendor = new Vendor (name, description);
return RedirectToAction("Index");
}


[HttpGet("/vendors/{id}")]
public ActionResult Show(int id)
{
Dictionary<string,object> model = new Dictionary<string, object>();
Vendor foundVendor = Vendor.Find(id);
List<Order> vendorOrders = foundVendor.Orders;
model.Add("vendor",foundVendor);
model.Add("orders",vendorOrders);
return View(model);
}


[HttpPost("/vendors/{id}/orders")]
public ActionResult Create(int vendorId,string orderTitle,string orderDescript, int orderPrice, int OrderPrice, string orderDate)
{
Dictionary<string,object> model = new Dictionary<string, object>();
Vendor foundVendor = Vendor.Find(vendorId);
Order newOrder = new Order (orderTitle,orderDescript,orderPrice,orderDate);
foundVendor.AddOrder(newOrder);
List<Order> vendorOrders =foundVendor.Orders;
model.Add("vendor",foundVendor);
model.Add("orders",vendorOrders);
return View("Show",model);
}
}
}