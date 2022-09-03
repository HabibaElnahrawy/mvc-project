using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Product3Controller : Controller
    {
       private ApplicationDbContext _context;
        public Product3Controller()
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
            var Product3 = _context.Product33.ToList();
            return View(Product3);
        }
    }
}