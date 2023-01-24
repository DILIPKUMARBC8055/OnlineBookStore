using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppliactionDbContext _context = null;
       public ProductsController()
        {
            _context = new AppliactionDbContext();
        }
        // GET: Products
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public ActionResult create()
        {
            ViewBag.BookType = new SelectList(_context.Products.Select(p => p.BookType));
            return View();
        }
        [HttpPost]
        public ActionResult create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}