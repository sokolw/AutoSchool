using AutoSchool.Data;
using AutoSchool.Models.Tables;
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
            IQueryable<Course> query = applicationDbContext.Courses
                .Include(a => a.Students)
                    .ThenInclude(z => z.User)
                .Include(b => b.Teacher)
                    .ThenInclude(x => x.User);

            var temp = query.ToList();

            return View(temp);
        }
    }
}
