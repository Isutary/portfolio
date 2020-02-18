using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioDbContext context;
        public HomeController(PortfolioDbContext Context)
        {
            context = Context;
        }
        public IActionResult Home()
        {
            ViewBag.Current = "Home";
            return View((from row in context.Homes select row).FirstOrDefault());
        }
        public IActionResult Projects() 
        {
            ViewBag.Current = "Projects";
            return View((from row in context.Projects select row).ToList()); 
        }
        public IActionResult Education()
        {
            ViewBag.Current = "Education";
            return View((from row in context.Educations select row).ToList());
        }
        public IActionResult Contact()
        {
            ViewBag.Current = "Contact";
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.ID = Guid.NewGuid();
                contact.isRead = false;
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Contact");
            }
            return View();
        }
    }
}
