using EssentialTools.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product{ Name = "Kayak", Category = "Watersports", Price = 275m},
            new Product{ Name = "Kayak", Category = "Watersports", Price = 275m},
            new Product{ Name = "Kayak", Category = "Watersports", Price = 275m},
            new Product{ Name = "Kayak", Category = "Watersports", Price = 275m},
            new Product{ Name = "Kayak", Category = "Watersports", Price = 275m}
        };
        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            //IValueCalculator calc = new LinqValueCalculator();

            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();





            ShoppingCart cart = new ShoppingCart(calc) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}