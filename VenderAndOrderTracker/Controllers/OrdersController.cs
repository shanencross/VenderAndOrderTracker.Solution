using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string description, float price, string date)
    {
      Vendor vendor = Vendor.Find(id);
      Order order = new Order(title, description, price, date);
      vendor.AddOrder(order);
      return RedirectToAction("Show", "Vendors", new { id = id });
    }
  }
}