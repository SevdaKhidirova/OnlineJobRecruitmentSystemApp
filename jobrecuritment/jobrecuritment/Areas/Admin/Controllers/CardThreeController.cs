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
    public class CardThreeController : Controller
    {
        private readonly AppDbContext _context;

        public CardThreeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CardThree
        public async Task<IActionResult> Index()
        {
            return View(await _context.CardThree.ToListAsync());
        }

      
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardThree = await _context.CardThree.FindAsync(id);
            if (cardThree == null)
            {
                return NotFound();
            }
            return View(cardThree);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Condition,Id")] CardThree cardThree)
        {
            if (id != cardThree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardThree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardThreeExists(cardThree.Id))
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
            return View(cardThree);
        }

        private bool CardThreeExists(int id)
        {
            return _context.CardThree.Any(e => e.Id == id);
        }
    }
}
