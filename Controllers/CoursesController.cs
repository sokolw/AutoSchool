using AutoSchool.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutoSchool.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext applicationDbContext;

        public CoursesController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var temp = applicationDbContext.Courses
                .Include(a => a.Users)
                .Include(a => a.Teacher)
                    .ThenInclude(a => a.User)
                .ToList();

            return View(temp);
        }
    }
}
