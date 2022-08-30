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
    public class EmployersController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<AppUser> userManager;
        public EmployersController(AppDbContext _db, IHttpContextAccessor _httpContextAccessor, UserManager<AppUser> _userManager)
        {
            db = _db;
            httpContextAccessor = _httpContextAccessor;
            userManager = _userManager;
        }
        public async Task<IActionResult> Index()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                EmployerResumeViewModel esvm = new EmployerResumeViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync(),
                    personalInfos = await db.PersonalInfos.ToListAsync(),
                    interests = await db.Interests.ToListAsync(),
                    education = await db.Educations.ToListAsync(),
                    experience = await db.Experience.ToListAsync(),
                    Documents = await db.Documents.ToListAsync(),
                    languages = await db.Languages.ToListAsync(),
                    links = await db.Links.ToListAsync(),
                    AppUser = await userManager.FindByIdAsync(userId),
                    NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).LastAsync()
                };
                return View(esvm);
            }
            else
            {
                EmployerResumeViewModel esvm = new EmployerResumeViewModel
                {
                    levels = await db.Levels.ToListAsync(),
                    categories = await db.Categories.ToListAsync(),
                    jobTypes = await db.JobTypes.ToListAsync(),
                    jobVacancies = await db.JobVacancies.ToListAsync(),
                    personalInfos = await db.PersonalInfos.ToListAsync(),
                    interests = await db.Interests.ToListAsync(),
                    education = await db.Educations.ToListAsync(),
                    experience = await db.Experience.ToListAsync(),
                    Documents = await db.Documents.ToListAsync(),
                    languages = await db.Languages.ToListAsync(),
                    links = await db.Links.ToListAsync()
                };
                return View(esvm);
            }
        }

        public async Task<IActionResult> Resume(int? Id)
        {
            if (Id == null) return View();

            PersonalInfo info = await db.PersonalInfos.FindAsync(Id);
            var userId = info.UserId;
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId != null)
            {
                ResumeViewModel resumes = new ResumeViewModel
                {
                    personalInfos = db.PersonalInfos.Where(x => x.Id == Id).OrderByDescending(x => x.Id).FirstOrDefault(),
                    interests = await db.Interests.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    education = await db.Educations.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    experience = await db.Experience.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    Documents = db.Documents.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    languages = await db.Languages.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    links = db.Links.Where(x => x.UserId ==userId).FirstOrDefault(),
                    appUser = await userManager.FindByIdAsync(userId),
                    personalInfosLs = await db.PersonalInfos.ToListAsync(),
                    interestsLs2 = await db.Interests.ToListAsync(),
                    educationLs2 = await db.Educations.ToListAsync(),
                    experienceLs2 = await db.Experience.ToListAsync(),
                    languagesLs2 = await db.Languages.ToListAsync(),
                    appUserLs = await userManager.Users.ToListAsync(),
                    documentsLs = await db.Documents.ToListAsync(),
                    AppUser = await userManager.FindByIdAsync(UserId),
                    NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).LastAsync()
                };

                return View(resumes);
            }
            else
            {
                ResumeViewModel resumes = new ResumeViewModel
                {
                    personalInfos = db.PersonalInfos.Where(x => x.Id == Id).OrderByDescending(x => x.Id).FirstOrDefault(),
                    interests = await db.Interests.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    education = await db.Educations.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    experience = await db.Experience.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    Documents = db.Documents.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    languages = await db.Languages.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToListAsync(),
                    links = db.Links.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    appUser = await userManager.FindByIdAsync(userId),
                    personalInfosLs = await db.PersonalInfos.ToListAsync(),
                    interestsLs2 = await db.Interests.ToListAsync(),
                    educationLs2 = await db.Educations.ToListAsync(),
                    experienceLs2 = await db.Experience.ToListAsync(),
                    languagesLs2 = await db.Languages.ToListAsync(),
                    appUserLs = await userManager.Users.ToListAsync(),
                    documentsLs = await db.Documents.ToListAsync()
                };

                return View(resumes);
            }
     
        }
    }
}
