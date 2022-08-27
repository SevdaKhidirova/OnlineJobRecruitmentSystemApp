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
    public class CardOneController : Controller
    {
        private readonly AppDbContext _context;

        public CardOneController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.CardOne.ToListAsync());
        }

        
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardOne = await _context.CardOne.FindAsync(id);
            if (cardOne == null)
            {
                return NotFound();
            }
            return View(cardOne);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Condition,Id")] CardOne cardOne)
        {
            if (id != cardOne.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardOne);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardOneExists(cardOne.Id))
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
            return View(cardOne);
        }

        private bool CardOneExists(int id)
        {
            return _context.CardOne.Any(e => e.Id == id);
        }
    }
}
