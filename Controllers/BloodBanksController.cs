using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lalit_Pant_Dot_Net_Assignment.Data;
using Lalit_Pant_Dot_Net_Assignment.Models;
using System.Threading.Tasks;

namespace Lalit_Pant_Dot_Net_Assignment.Controllers
{
    public class BloodBankController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BloodBankController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ: Display List of Blood Banks
        public async Task<IActionResult> Index()
        {
            return View(await _context.BloodBanks.ToListAsync());
        }

        // CREATE: Show Create Form
        public IActionResult Create()
        {
            return View();
        }

        // CREATE: Save New Blood Bank
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Location,Contact")] BloodBank bloodBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodBank);
        }

        // READ: Show Details of a Blood Bank
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var bloodBank = await _context.BloodBanks.FindAsync(id);
            if (bloodBank == null) return NotFound();

            return View(bloodBank);
        }

        // UPDATE: Show Edit Form
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var bloodBank = await _context.BloodBanks.FindAsync(id);
            if (bloodBank == null) return NotFound();

            return View(bloodBank);
        }

        // UPDATE: Save Edited Blood Bank
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location,Contact")] BloodBank bloodBank)
        {
            if (id != bloodBank.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(bloodBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodBank);
        }

        // DELETE: Confirm Delete View
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var bloodBank = await _context.BloodBanks.FindAsync(id);
            if (bloodBank == null) return NotFound();

            return View(bloodBank);
        }

        // DELETE: Remove Blood Bank from Database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloodBank = await _context.BloodBanks.FindAsync(id);
            if (bloodBank != null)
            {
                _context.BloodBanks.Remove(bloodBank);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
