using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controllers
{
public class HomeCotroller : Controller

{
[HttpGet("/")]
public ActionResult Index()
{
return View();

}
}
}