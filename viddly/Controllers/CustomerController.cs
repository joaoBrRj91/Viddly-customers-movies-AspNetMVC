using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viddly.Models;

namespace viddly.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {

            //eager loading is different of the lazy loading
            var customers = _context.Custumers.Include(m => m.MembershipType);
            return View(customers);
        }


        public ActionResult Details(int customerId)
        {
            var customer = _context.Custumers.SingleOrDefault(c => c.Id.Equals(customerId));

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}