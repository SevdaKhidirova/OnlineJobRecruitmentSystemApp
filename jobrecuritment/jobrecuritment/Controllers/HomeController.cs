using jobrecuritment.DAL;
using jobrecuritment.Models;
using jobrecuritment.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace jobrecuritment.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        private readonly UserManager<AppUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        public HomeController(AppDbContext _db, IHttpContextAccessor _httpContextAccessor, UserManager<AppUser> _userManager)
        {
            db = _db;
            userManager = _userManager;
            httpContextAccessor = _httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                HomeViewModel hvm = new HomeViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync(),
                    cardOne = await db.CardOne.OrderBy(x => x.Id).LastAsync(),
                    cardTwo = await db.CardTwo.OrderBy(x => x.Id).LastAsync(),
                    cardThree = await db.CardThree.OrderBy(x => x.Id).LastAsync(),
                    companyLogos = await db.CompanyLogos.ToListAsync(),
                    AppUser = await userManager.FindByIdAsync(userId),
                    NavbarProfil =  db.PersonalInfos.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefault()
                };
                return View(hvm);
            }
            else
            {
                HomeViewModel hvm = new HomeViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync(),
                    cardOne = await db.CardOne.OrderBy(x => x.Id).LastAsync(),
                    cardTwo = await db.CardTwo.OrderBy(x => x.Id).LastAsync(),
                    cardThree = await db.CardThree.OrderBy(x => x.Id).LastAsync(),
                    companyLogos = await db.CompanyLogos.ToListAsync()
                };
                return View(hvm);
            }
           
        }

     
    }
}
