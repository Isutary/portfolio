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
        private IRepository repo;
        public HomeController(IRepository Repo)
        {
            repo = Repo;
        }
        public IActionResult Home()
        {
            ViewBag.Current = "Home";
            return View(repo.list.home);
        }
        public IActionResult Projects() 
        {
            ViewBag.Current = "Projects";
            return View(); 
        }
        public IActionResult Education()
        {
            ViewBag.Current = "Education";
            return View(repo.list.education);
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
                repo.list.contact.Add(contact);
                return RedirectToAction("Contact");
            }
            return View();
        }
    }
}
