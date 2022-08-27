using jobrecuritment.DAL;
using jobrecuritment.Models;
using jobrecuritment.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace jobrecuritment.Controllers
{
    public class VacanciesController : Controller
    {
        private readonly AppDbContext db;
        private readonly UserManager<AppUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        public VacanciesController(AppDbContext _db, UserManager<AppUser> _userManager, IHttpContextAccessor _httpContextAccessor)
        {
            db = _db;
            userManager = _userManager;
            httpContextAccessor = _httpContextAccessor;
        }

        public async Task<IActionResult> Vacancy()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                FilterViewModel fvm = new FilterViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync(),
                    AppUser = await userManager.FindByIdAsync(userId),
                    NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).LastAsync(),
                    userToVacancies= await db.userToVacancies.Include(x => x.AppUser).Include(x => x.JobVacancy).Where(x => x.UserId == userId).ToListAsync()
                };
                return View(fvm);
            }
            else
            {
                FilterViewModel fvm = new FilterViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync()
                  
                };
                return View(fvm);
            }
          
    
        }

        public async Task<IActionResult> UserToVacancyConnection(int id)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                UserToVacancy aplyToVacancy = new UserToVacancy()
                {
                    UserId = userId,
                    VacancyId = id,
                    AplyTime=DateTime.Now
                };
                await db.userToVacancies.AddAsync(aplyToVacancy);
                db.SaveChanges();
                return RedirectToAction("Vacancy");
            }
            return RedirectToAction("Vacancy", "Vacancies");
        }

        public async Task<IActionResult> Summary(int? Id)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (Id != null)
            {
                if (userId != null)
                {
                    SummaryViewModel sm = new SummaryViewModel
                    {
                        jobVacancy = await db.JobVacancies.Where(x => x.Id == Id).OrderByDescending(x => x.Id).LastAsync(),
                        AppUser = await userManager.FindByIdAsync(userId),
                        NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).LastAsync(),
                        apliedVacancy = db.userToVacancies.Find(Id)
                    };
                    
                    return View(sm);
                }
                else
                {
                    SummaryViewModel sm = new SummaryViewModel
                    {
                        jobVacancy = await db.JobVacancies.Where(x => x.Id == Id).OrderByDescending(x => x.Id).LastAsync()
                    };
                    return View(sm);
                }
            }
            return View();
        }
    }
}
