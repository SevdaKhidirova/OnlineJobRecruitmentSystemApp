using jobrecuritment.DAL;
using jobrecuritment.Helpers;
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
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly AppDbContext db;
        private readonly IWebHostEnvironment env;
        public AccountController(UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager, SignInManager<AppUser> _signInManager, IHttpContextAccessor _httpContextAccessor, AppDbContext _db, IWebHostEnvironment _env)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
            httpContextAccessor = _httpContextAccessor;
            db = _db;
            env = _env;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {

            if (!ModelState.IsValid) return View();

            AppUser user = new AppUser
            {
                Name=viewModel.Name,
                Surname=viewModel.Surname,
                Email=viewModel.Email,
                PhoneNumber=viewModel.PhoneNumber,
                UserName=viewModel.Email
            };

            IdentityResult result = await userManager.CreateAsync(user, viewModel.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(viewModel);
            }

            return RedirectToAction("Login", "Account");

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid) return View();

            AppUser loginUser = await userManager.FindByEmailAsync(viewModel.Email);
            if(loginUser==null)
            {
                ModelState.AddModelError("", "Email  or Password is wrong");
                return View(viewModel);
            }
            if (loginUser.Status == true)
            {
                ModelState.AddModelError("", "You are blocked,please contact with admin");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(loginUser, viewModel.Password, false , true);

            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "You are lock out ,pls wait 30 seconds");
                }
                else
                {
                    ModelState.AddModelError("", "Email  or Password is wrong");
                }
                return View(viewModel);
            }
            var userV1 = db.PersonalInfos.FirstOrDefault(x => x.UserId == loginUser.Id);
            var userV2 = db.Documents.FirstOrDefault(x => x.UserId == loginUser.Id);
            if (userV1==null)
            {
                return RedirectToAction("Personal", "Account");
            }
            return RedirectToAction("Index", "Home");
            
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Personal()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Personal(PersonalInfoViewModel viewModel)
        {
            if (!ModelState.IsValid) return View();
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!viewModel.ProfilImg.ContentType.Contains("image"))
            {
                ModelState.AddModelError("img", "File is not an image");
                return View(viewModel);
            }

            if (!viewModel.ProfilImg.isSmallerThan(1073741824))
            {
                ModelState.AddModelError("img", "File is too big");
                return View(viewModel);
            }
            string path = env.WebRootPath + @"\assets\images\user";
            string fileName = Guid.NewGuid().ToString() + viewModel.ProfilImg.FileName;
            string finalPath = Path.Combine(path, fileName);

            using (FileStream stream = new FileStream(finalPath, FileMode.Create))
            {
                await viewModel.ProfilImg.CopyToAsync(stream);
            }
            PersonalInfo personalInfo = new PersonalInfo
               {
                Name = viewModel.Name,
                Surname=viewModel.Surname,
                FatherName=viewModel.FatherName,
                DateOfBiirth=viewModel.DateOfBirth,
                Gender=viewModel.Gender,
                Adress=viewModel.Adress,
                RegistrAdress=viewModel.RegistrAdress,
                UserId=userId,
                RegistrationTime=DateTime.Now
               };

            personalInfo.ProfilImage = fileName;

            if (userId != null)
            {
                db.PersonalInfos.Add(personalInfo);
                db.SaveChanges();
            }

            return RedirectToAction("Interests", "Account");
        }
        public IActionResult Interests()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Interests(InterestViewmodel model)
        {
           
            if (!ModelState.IsValid) return View();
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Interests interests = new Interests
            {
                InterestItem = model.InterestItem,
                UserId = userId
            };
           
            if (userId != null)
            {
                db.Interests.Add(interests);
                db.SaveChanges();
            }

            return View();
        }
        public async Task<IActionResult> SelectInterestsItem()
        {
            return View("_InterestsPartial",await db.Interests.ToListAsync());
        }
        public IActionResult Education()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Education(EducationViewModel model)
        {
            if (!ModelState.IsValid) return View();
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            Education educationItem = new Education
            {
                Degree=model.Degree,
                University=model.University,
                EntranceYear=model.EntranceYear,
                GraduationYear=model.GraduationYear,
                EntranceScore=model.EntranceScore,
                Specialization=model.Specialization,
                UserId=userId
            };

            if (userId != null)
            {
                db.Educations.Add(educationItem);
                db.SaveChanges();
            }

            return View();
        }
        public IActionResult Experience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Experience(ExperienceViewModel model)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Experience experience = new Experience
            {
                CompanyName=model.CompanyName,
                Department=model.Department,
                Responsibilities=model.Responsibilities,
                StartToWork=model.StartToWork,
                EndToWork=model.EndToWork,
                UserId=userId
            };
            if (userId != null)
            {
                db.Experience.Add(experience);
                db.SaveChanges();
            }

            return View();
        }

        public IActionResult Document()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Document(DocumentViewModel model)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Document document = new Document
            {
                Diploms = model.Diploms,
                Certificate = model.Certificate,
                MotivationLetter =model.MotivationLetter,
                UserId=userId,
                Salary=model.Salary,
                Position=model.Position
            };
            if (model.Cv != null)
            {
                if (!model.Cv.ContentType.Contains("pdf"))
                {
                    ModelState.AddModelError("cv", "File is not pdf");
                    return View(model);
                }
                if(model.Cv.Length< 3073741824)
                {
                    ModelState.AddModelError("cv", "File is too big");
                    return View(model);
                }

                string path = env.WebRootPath + @"\assets\images\pdf";
                string fileName = Guid.NewGuid().ToString() + model.Cv.FileName;
                string finalPath = Path.Combine(path, fileName);

                using (FileStream stream = new FileStream(finalPath, FileMode.Create))
                {
                    await model.Cv.CopyToAsync(stream);
                }
                document.Cv = fileName;
            }

            if (userId != null)
            {
                db.Documents.Add(document);
                db.SaveChanges();
            }

            return RedirectToAction("Language", "Account");
        }

        public IActionResult Language()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Language(LanguageViewModel model)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Language language = new Language
            {
                LanguageItem=model.LanguageItem,
                Read=model.Read,
                Write=model.Write,
                Speak=model.Speak,
                UserId=userId
            };
            if (userId != null)
            {
                db.Languages.Add(language);
                db.SaveChanges();
            }
            return View();
        }
        public IActionResult ContactInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactInfo(LinkViewModel model)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Link info = new Link
            {
                Linkedin=model.Linkedin,
                Github=model.Github,
                Facebook=model.Facebook,
                UserId=userId
            };

            if (userId != null)
            {
                db.Links.Add(info);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        //public async Task<IActionResult> CreatrRoles()
        //{
        //    await roleManager.CreateAsync(new IdentityRole { Name = "Member" });
        //    await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    await roleManager.CreateAsync(new IdentityRole { Name = "SuperAdmin" });

        //    return Content("Ok");
        //}

        //public async Task<IActionResult> AddRoleToUser()
        //{
        //    AppUser user = await userManager.FindByNameAsync("sevda.khidirova68@gmail.com");
        //    await userManager.AddToRoleAsync(user, "SuperAdmin");

        //    AppUser user2 = await userManager.FindByNameAsync("kenan@gmail.com");
        //    await userManager.AddToRoleAsync(user2, "Admin");

        //    AppUser user3 = await userManager.FindByNameAsync("isabala@code.edu.az");
        //    await userManager.AddToRoleAsync(user3, "Member");

        //    return Content("Ok");
        //}
    }
}
