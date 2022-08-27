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
    public class ProfilController : Controller
    {

        private readonly AppDbContext db;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<AppUser> userManager;
        public ProfilController(AppDbContext _db, IHttpContextAccessor _httpContextAccessor, UserManager<AppUser> _userManager)
        {
            db = _db;
            httpContextAccessor = _httpContextAccessor;
            userManager = _userManager;
        }
        public async Task<IActionResult> InfoAppeal()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId != null)
            {
                ProfilViewModel pvm = new ProfilViewModel
                {
                    AppUser = await userManager.FindByIdAsync(UserId),
                    NavbarProfil = db.PersonalInfos.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    interests = await db.Interests.Where(x => x.UserId == UserId).ToListAsync(),
                    education = db.Educations.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    experience = await db.Experience.Where(x => x.UserId == UserId).ToListAsync(),
                    languages = await db.Languages.Where(x => x.UserId == UserId).ToListAsync(),
                    links = db.Links.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).FirstOrDefault(),
                    jobVacancy=await db.JobVacancies.ToListAsync(),
                    userToVacancy=await db.userToVacancies.Where(x=>x.UserId==UserId).ToListAsync()
                };
                return View(pvm);
            }
          

            return View();
        }
        public IActionResult removeAppeal(int id)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            UserToVacancy deleteVacancy = db.userToVacancies.Where(x => x.VacancyId == id).FirstOrDefault();
            db.userToVacancies.Remove(deleteVacancy);
            db.SaveChanges();

            return RedirectToAction("InfoAppeal", "Profil");
        }

        public async Task<IActionResult> PostAd()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserId != null)
            {
                ProfilViewModel pvm = new ProfilViewModel
                {
                    AppUser = await userManager.FindByIdAsync(UserId),
                    NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).LastAsync(),
                    jobVacancy=await db.JobVacancies.Where(x=>x.UserId==UserId).ToListAsync(),
                    levels=await db.Levels.ToListAsync(),
                    category=await db.Categories.ToListAsync(),
                    jobType=await db.JobTypes.ToListAsync()
                };
                return View(pvm);
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> PostAd(JobVacancy model)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.PostTime = DateTime.Now;
            model.UserId = UserId;
            await db.JobVacancies.AddAsync(model);
            db.SaveChanges();

            return RedirectToAction("PostAd", "Profil");
        }

        public async Task<IActionResult> EditAd(int id)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            EditAdViewModel evm = new EditAdViewModel
            {
                category=await db.Categories.ToListAsync(),
                levels=await db.Levels.ToListAsync(),
                jobType=await db.JobTypes.ToListAsync(),
                jobVacancy=await db.JobVacancies.FindAsync(id),
                AppUser = await userManager.FindByIdAsync(UserId),
                NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).LastAsync(),
                jobVacancyLs= await db.JobVacancies.Where(x => x.UserId == UserId).ToListAsync(),
            };
            return View(evm);
        }
      
        [HttpPost]
        public IActionResult EditAd(JobVacancy model)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.UserId = UserId;
            model.PostTime = DateTime.Now;
         
            db.JobVacancies.Update(model);
            db.SaveChanges();
            return RedirectToAction("PostAd", "Profil");
        }
        public async Task<IActionResult> Delete(int id)
        {
            JobVacancy jv = await db.JobVacancies.FindAsync(id);
            db.JobVacancies.Remove(jv);
            db.SaveChanges();
            return RedirectToAction("PostAd", "Profil");
        }
    }
}
