using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Models.SchoolViewmodels;
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly SchoolContext _context;

        public HomeController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //ViewData["Message"] = "Your application description page.";

            //return View();

            IQueryable<EnrollmentDateGroups> data =
                from student in _context.Student
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentDateGroups()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
