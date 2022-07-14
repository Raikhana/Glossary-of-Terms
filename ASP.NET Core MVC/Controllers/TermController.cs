using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_MVC.Models;

namespace ASP.NET_Core_MVC.Controllers
{
    public class TermController : Controller
    {
        private TermContext context { get; set; }
        public TermController(TermContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Chapters = context.Chapters.OrderBy(g => g.Name).ToList();
            return View("Edit", new Term());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Chapters = context.Chapters.OrderBy(g => g.Name).ToList();
            var term = context.Terms.Find(id);
            return View(term);
        }

        [HttpPost]
        public IActionResult Edit(Term term)
        {
            if(ModelState.IsValid)
            {
                if(term.TermId == 0)
                    context.Terms.Add(term);
                else
                    context.Terms.Update(term);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (term.TermId == 0) ? "Add" : "Edit";
                ViewBag.Chapters = context.Chapters.OrderBy(g => g.Name).ToList();
                return View(term);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var term = context.Terms.Find(id);
            return View(term);
        }

        [HttpPost]
        public IActionResult Delete (Term term)
        {
            context.Terms.Remove(term);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
