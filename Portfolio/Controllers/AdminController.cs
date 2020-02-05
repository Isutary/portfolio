using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repo;
        public AdminController(IRepository Repo)
        {
            repo = Repo;
        }
        /////   HOME START  /////
        public IActionResult Home() => View(repo.list.home);
        public IActionResult HomeEdit() => View(repo.list.home);
        [HttpPost]
        public IActionResult HomeEdit(Home home)
        {
            if (ModelState.IsValid)
            {
                repo.list.home = home;
                return RedirectToAction("Home");
            }
            return View(home);
        }
        /////   HOME END    /////
        /////   EDUCATION START  /////
        public IActionResult Education() => View(repo.list.education);
        public IActionResult EducationEdit(Guid ID)
        {
            Education education = repo.list.education.Find((current) => current.ID == ID);
            return View(education != null ? education : new Education());
        }
        [HttpPost]
        public IActionResult EducationEdit(Education education)
        {
            if (ModelState.IsValid)
            {
                int index = repo.list.education.FindIndex((current) => current.ID == education.ID);
                if (index != -1) repo.list.education[index] = education;
                else
                {
                    education.ID = Guid.NewGuid();
                    repo.list.education.Add(education);
                }
                return RedirectToAction("Education");
            }
            return View(education);
        }
        [HttpPost] 
        public IActionResult EducationDelete(Guid ID)
        {
            Education education = repo.list.education.Find((current) => current.ID == ID);
            repo.list.education.Remove(education);
            return RedirectToAction("Education");
        }
        /////   EDUCATION END   /////
        /////   PROJECTS START  /////
        public IActionResult Projects() => View(repo.list.projects);
        /////   PROJECTS END    /////
        /////   CONTACT START    /////
        public IActionResult Contact() => View(repo.list.contact);
        [HttpPost]
        public IActionResult ContactEdit(Guid ID)
        {
            int index = repo.list.contact.FindIndex((current) => current.ID == ID);
            repo.list.contact[index].isRead = repo.list.contact[index].isRead ? false : true;
            return RedirectToAction("Contact");
        }
        [HttpPost]
        public IActionResult ContactDelete(Guid ID)
        {
            Contact contact = repo.list.contact.Find((current) => current.ID == ID);
            repo.list.contact.Remove(contact);
            return RedirectToAction("Contact");
        }
        /////   CONTACT END    /////
    }
}
