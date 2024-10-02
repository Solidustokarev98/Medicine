using Medicine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Medicine.Controllers
{
    public class HomeController : Controller
    {
        private readonly DrugsDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new DrugsDbContext();
        }

        public ActionResult Index()
        {

            var drugAvailability = _dbContext.DrugAvailability
                .Include(da => da._Drug)
                .Include(da => da._Pharmacy)
                .ToList();

            return View(drugAvailability);
        }

    }
}
