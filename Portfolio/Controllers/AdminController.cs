using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private PortfolioDbContext context;
        public AdminController(PortfolioDbContext Context)
        {
            context = Context;
        }
        /////   HOME START  /////
        public IActionResult Home() => View((from row in context.Homes select row).First());
        public IActionResult HomeEdit() => View((from row in context.Homes select row).First());
        [HttpPost]
        public IActionResult HomeEdit(Home home)
        {
            if (ModelState.IsValid)
            {
                context.Homes.Update(home);
                context.SaveChanges();
                return RedirectToAction("Home");
            }
            return View(home);
        }
        /////   HOME END    /////
        /////   EDUCATION START  /////
        public IActionResult Education() => View((from row in context.Educations select row).ToList());
        public IActionResult EducationEdit(Guid ID)
        {
            Education education = (from row in context.Educations where row.ID == ID select row).FirstOrDefault();
            return View(education ?? new Education());
        }
        [HttpPost]
        public IActionResult EducationEdit(Education education)
        {
            if (ModelState.IsValid)
            {
                if (education != null) context.Educations.Update(education);
                else
                {
                    education.ID = Guid.NewGuid();
                    context.Educations.Add(education);
                }
                context.SaveChanges();
                return RedirectToAction("Education");
            }
            return View(education);
        }
        [HttpPost] 
        public IActionResult EducationDelete(Guid ID)
        {
            Education education = (from row in context.Educations where row.ID == ID select row).FirstOrDefault();
            context.Educations.Remove(education);
            context.SaveChanges();
            return RedirectToAction("Education");
        }
        /////   EDUCATION END   /////
        /////   PROJECTS START  /////
        public IActionResult Projects() => View((from row in context.Projects select row).ToList());
        public IActionResult ProjectsEdit(Guid ID)
        {
            Projects projects = (from row in context.Projects where row.ID == ID select row).FirstOrDefault();
            return View(projects ?? new Projects());
        }
        [HttpPost]
        public IActionResult ProjectsEdit(Projects projects)
        {
            if (ModelState.IsValid)
            {
                if (projects != null) context.Projects.Update(projects);
                else
                {
                    projects.ID = Guid.NewGuid();
                    context.Projects.Add(projects);
                }
                context.SaveChanges();
                return RedirectToAction("Projects");
            }
            return View(projects);
        }
        [HttpPost]
        public IActionResult ProjectsDelete(Guid ID)
        {
            Projects projects = (from row in context.Projects where row.ID == ID select row).FirstOrDefault();
            context.Projects.Remove(projects);
            context.SaveChanges();
            return RedirectToAction("Projects");
        }
        /////   PROJECTS END    /////
        /////   CONTACT START    ////
        public IActionResult Contact() => View((from row in context.Contacts select row).ToList());
        [HttpPost]
        public IActionResult ContactEdit(Guid ID)
        {
            Contact contact = (from row in context.Contacts where row.ID == ID select row).FirstOrDefault();
            //int index = repo.list.contact.FindIndex((current) => current.ID == ID);
            contact.isRead = contact.isRead ? false : true;
            context.SaveChanges();
            //repo.list.contact[index].isRead = repo.list.contact[index].isRead ? false : true;
            return RedirectToAction("Contact");
        }
        [HttpPost]
        public IActionResult ContactDelete(Guid ID)
        {
            Contact contact = (from row in context.Contacts where row.ID == ID select row).FirstOrDefault();
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Contact");
        }
        /////   CONTACT END    /////
    }
}
