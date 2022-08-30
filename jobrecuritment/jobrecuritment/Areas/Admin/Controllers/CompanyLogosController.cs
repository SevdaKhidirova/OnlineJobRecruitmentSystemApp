using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using jobrecuritment.DAL;
using jobrecuritment.Models;
using jobrecuritment.Helpers;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace jobrecuritment.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CompanyLogosController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly AppDbContext _context;

        public CompanyLogosController(AppDbContext context , IWebHostEnvironment _env)
        {
            _context = context;
            env = _env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyLogos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyLogo = await _context.CompanyLogos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyLogo == null)
            {
                return NotFound();
            }

            return View(companyLogo);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CompanyLogo companyLogo)
        {
          
            if (!companyLogo.LogoImg.ContentType.Contains("image"))
            {
                ModelState.AddModelError("LogoImg", "File is not an image");
                return View(companyLogo);
            }

            if(!companyLogo.LogoImg.isSmallerThan(1073741824))
            {
                ModelState.AddModelError("LogoImg", "File is too large");
                return View(companyLogo);
            }

            string path = env.WebRootPath + @"\assets\images\logo";
            string fileName = Guid.NewGuid().ToString() + companyLogo.LogoImg.FileName;
            string finalPath = Path.Combine(path, fileName);

            using(FileStream stream =new FileStream(finalPath, FileMode.Create))
            {
                await companyLogo.LogoImg.CopyToAsync(stream);
            }

                companyLogo.LogoImage = fileName;
                _context.Add(companyLogo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyLogo = await _context.CompanyLogos.FindAsync(id);
            if (companyLogo == null)
            {
                return NotFound();
            }
            return View(companyLogo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,CompanyLogo companyLogo)
        {
            if (id != companyLogo.Id)
            {
                return NotFound();
            }

            if (companyLogo.LogoImg != null)
            {
                if (!companyLogo.LogoImg.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("LogoImg", "File is not an image");
                    return View(companyLogo);
                }

                if (!companyLogo.LogoImg.isSmallerThan(3145728))
                {
                    ModelState.AddModelError("LogoImg", "File is too large");
                    return View(companyLogo);
                }

                string path = env.WebRootPath + @"\assets\images\logo";

                if (System.IO.File.Exists(Path.Combine(path, companyLogo.LogoImage)))
                {
                    System.IO.File.Delete(Path.Combine(path, companyLogo.LogoImage));
                }
                string fileName = Guid.NewGuid().ToString() + companyLogo.LogoImg.FileName;
                string finalPath = Path.Combine(path, fileName);

                using (FileStream stream = new FileStream(finalPath, FileMode.Create))
                {
                    await companyLogo.LogoImg.CopyToAsync(stream);
                }

                companyLogo.LogoImage =fileName;
            }

            _context.Update(companyLogo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var companyLogo = await _context.CompanyLogos
                .FirstOrDefaultAsync(m => m.Id == id);

            if (companyLogo == null)
            {
                return NotFound();
            }

            return View(companyLogo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyLogo = await _context.CompanyLogos.FindAsync(id);

            string path = env.WebRootPath + @"\assets\images\logo";
            string filename = companyLogo.LogoImage;
            string final = Path.Combine(path, filename);

            if (System.IO.File.Exists(final))
            {
                System.IO.File.Delete(final);
            }
            _context.CompanyLogos.Remove(companyLogo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyLogoExists(int id)
        {
            return _context.CompanyLogos.Any(e => e.Id == id);
        }
    }
}
