using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
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

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor vendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
  }
}