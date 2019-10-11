using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {

        // This one takes you to the list of vendors

        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        // This one takes you to the new Vendor form

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        // This one creates new Vendors:

        [HttpPost("/vendor")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        // This one shows you details for a specific Vendor

        [HttpGet("/vendor/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("order", vendorOrders);
            return View(model);
        }

        // This one creates new Orders within a given Vendor, not new Vendors:

        [HttpPost("/vendor/{vendorId}/order")]
        public ActionResult Create(int vendorId, string orderName, string deliveryDate, string breadCount, string pastryCount)
        {
            int breadInt = int.Parse(breadCount);
            int pastryInt = int.Parse(pastryCount);
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderName, deliveryDate, breadInt, pastryInt);
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Orders;
            model.Add("order", vendorOrders);
            model.Add("vendor", foundVendor);
            return View("Show", model);
        }

    }
}