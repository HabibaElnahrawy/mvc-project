using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Product2Controller : Controller
    {
       private ApplicationDbContext _context;
        public Product2Controller()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: products
        public ActionResult Index()
        {
            var Product2 = _context.Product22.ToList();
            return View(Product2);
        }
    }
}