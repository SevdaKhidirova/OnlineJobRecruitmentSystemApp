using jobrecuritment.DAL;
using jobrecuritment.Models;
using jobrecuritment.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace jobrecuritment.Controllers
{
    public class EditProfilController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IWebHostEnvironment env;
        private readonly UserManager<AppUser> userManager;
        public EditProfilController(AppDbContext _db, IHttpContextAccessor _httpContextAccessor, IWebHostEnvironment _env, UserManager<AppUser> _userManager)
        {
            db = _db;
            httpContextAccessor = _httpContextAccessor;
            env = _env;
            userManager = _userManager;
        }
        public async Task<IActionResult> Personal(string userId)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            EditPersonalInfoViewModel epvm = new EditPersonalInfoViewModel
            {
                PersonalInfo= db.PersonalInfos.Where(x => x.UserId == UserId).FirstOrDefault(),
                //AppUser = await userManager.FindByIdAsync(userId),
                //NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).LastAsync()
            };
           
            //PersonalInfo personalInfo = db.PersonalInfos.Where(x=>x.UserId==UserId).FirstOrDefault();

            return View(epvm);
        }
        [HttpPost]
        public async Task<IActionResult> Personal(PersonalInfo info)
        {
            if (info.ProfilImg != null)
            {
                if (!info.ProfilImg.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("", "File is not an image");
                    return View(info);
                }
                //if (info.ProfilImg.Length> 3073741824)
                //{
                //    ModelState.AddModelError("ProfilImg", "File is too big");
                //    return View(info);
                //}
               
                string path = env.WebRootPath + @"\assets\images\user";
                string fileName = Guid.NewGuid().ToString() + info.ProfilImg.FileName;
                string finalPath = Path.Combine(path, fileName);

                if (System.IO.File.Exists(Path.Combine(path, fileName)))
                {
                    System.IO.File.Delete(Path.Combine(path, fileName));
                }

                using (FileStream stream = new FileStream(finalPath, FileMode.Create))
                {
                    await info.ProfilImg.CopyToAsync(stream);
                }
                info.ProfilImage = fileName;
            }

             db.PersonalInfos.Update(info);
             await db.SaveChangesAsync();

             return RedirectToAction("InfoAppeal", "Profil");
        }

        public async Task<IActionResult> Interests()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            InterestViewmodel interests = new InterestViewmodel
            {
                interests=await db.Interests.Where(x => x.UserId == UserId).ToListAsync(),
                categories=await db.Categories.ToListAsync()
            };

            return View(interests);
        }
        [HttpPost]
        public  IActionResult Interests(Interests intersetItem)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            intersetItem.UserId = UserId;
            db.Interests.Add(intersetItem);
            db.SaveChanges();
            return RedirectToAction("Interests", "EditProfil");
        }
        public async Task<IActionResult> DeleteInterest(int Id)
        {
            Interests interestItem = await db.Interests.FindAsync(Id);
            db.Interests.Remove(interestItem);
            db.SaveChanges();
            return RedirectToAction("Interests", "EditProfil");
        }
        public async Task<IActionResult> Education()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            EditEducationViewModel evm = new ()
            {
                education = await db.Educations.Where(x => x.UserId == UserId).ToListAsync(),
                AppUser = await userManager.FindByIdAsync(UserId),
                NavbarProfil = await db.PersonalInfos.Where(x => x.UserId == UserId).OrderByDescending(x => x.Id).LastAsync()
            };


            return View();
        }
        public IActionResult Experience()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            EditExperienceViewModel exvm = new()
            {
                experience= db.Experience.Where(x=>x.UserId==UserId).ToList()
            };
            return View(exvm);
        }

        [HttpPost]
        public IActionResult Experience(Experience experience)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            experience.UserId = UserId;
            db.Experience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Experience", "EditProfil");
        }

        public IActionResult Document()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Document document = db.Documents.Where(x => x.UserId == UserId).FirstOrDefault();
            return View(document);
        }

        public IActionResult Language()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            EditLanguageViewModel lvm = new()
            {
                languages=db.Languages.Where(x=>x.UserId==UserId).ToList()
            };
            return View(lvm);
        }

        [HttpPost]
        public IActionResult Language(Language language)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            language.UserId = UserId;
            db.Languages.Add(language);
            db.SaveChanges();
            return RedirectToAction("Language", "EditProfil");
        }
        public IActionResult ContactInfo()
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Link links = db.Links.Where(x => x.UserId == UserId).FirstOrDefault();
            return View(links);
        }

        [HttpPost]
        public IActionResult ContactInfo(Link link)
        {
            string UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            link.UserId = UserId;
            db.Links.Add(link);
            db.SaveChanges();
            return RedirectToAction("Link", "EditProfil");
        }
    }
}
