using Emulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emulator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private Models.PurchaseDBEntities db = new Models.PurchaseDBEntities();

        public ActionResult Index()
        {
            var Items = db.Products;
            return View(Items);
        }

        //[HttpGet]
        //public ActionResult Form(int item_id = 0)
        //{
        //    ViewBag.Item = item_id;
        //    return PartialView();
        //}

        [HttpPost]
        public string Form(string Product, decimal Price, int Quantity)
        {
            Order order = new Order
            {
                ProductId = Product,
                Price = Price,
                Quantity = Quantity,
                Status = "Completed"
            };
            db.Orders.Add(order);
            db.SaveChanges();
            return "Consimple: Спасибо за Вашу покупку!";
        }
    }
}