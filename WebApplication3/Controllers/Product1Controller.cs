using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Product1Controller : Controller
    {
                private ApplicationDbContext _context;
        public Product1Controller()
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
            var Product1 = _context.Product11.ToList();
            return View(Product1);
        }
    }
}