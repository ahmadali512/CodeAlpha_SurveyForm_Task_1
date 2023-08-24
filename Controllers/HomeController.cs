using CodeAlpha_Task_1.Data;
using CodeAlpha_Task_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeAlpha_Task_1.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(Question1 q1)
        {
            _db.Question1.Add(q1);
            _db.SaveChanges();
            return View(q1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}