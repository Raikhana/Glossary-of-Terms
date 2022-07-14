using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_MVC.Models;

namespace ASP.NET_Core_MVC.Controllers
{
    public class HomeController : Controller
    {
        private TermContext context { get; set; }
        public HomeController(TermContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var terms = context.Terms
                .Include(m => m.Chapter)
                .OrderBy(n => n.TermName)
                .ToList();
            return View(terms);
        }
    }
}
