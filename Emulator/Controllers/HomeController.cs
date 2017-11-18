using Emulator.Models;
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

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

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