using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using jobrecuritment.DAL;
using jobrecuritment.Models;
using Microsoft.AspNetCore.Authorization;

namespace jobrecuritment.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CardTwoController : Controller
    {
        private readonly AppDbContext _context;

        public CardTwoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.CardTwo.ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTwo = await _context.CardTwo.FindAsync(id);
            if (cardTwo == null)
            {
                return NotFound();
            }
            return View(cardTwo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Condition,Id")] CardTwo cardTwo)
        {
            if (id != cardTwo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardTwo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardTwoExists(cardTwo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cardTwo);
        }

        private bool CardTwoExists(int id)
        {
            return _context.CardTwo.Any(e => e.Id == id);
        }
    }
}
