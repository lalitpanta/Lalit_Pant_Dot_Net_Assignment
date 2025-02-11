using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lalit_Pant_Dot_Net_Assignment.Data;
using Lalit_Pant_Dot_Net_Assignment.Models;

namespace Lalit_Pant_Dot_Net_Assignment.Controllers
{
    public class DonationRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonationRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DonationRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonationRequests.ToListAsync());
        }

        // GET: DonationRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donationRequest = await _context.DonationRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donationRequest == null)
            {
                return NotFound();
            }

            return View(donationRequest);
        }

        // GET: DonationRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonationRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate")] DonationRequest donationRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donationRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donationRequest);
        }

        // GET: DonationRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donationRequest = await _context.DonationRequests.FindAsync(id);
            if (donationRequest == null)
            {
                return NotFound();
            }
            return View(donationRequest);
        }

        // POST: DonationRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate")] DonationRequest donationRequest)
        {
            if (id != donationRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donationRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonationRequestExists(donationRequest.Id))
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
            return View(donationRequest);
        }

        // GET: DonationRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donationRequest = await _context.DonationRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donationRequest == null)
            {
                return NotFound();
            }

            return View(donationRequest);
        }

        // POST: DonationRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donationRequest = await _context.DonationRequests.FindAsync(id);
            if (donationRequest != null)
            {
                _context.DonationRequests.Remove(donationRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonationRequestExists(int id)
        {
            return _context.DonationRequests.Any(e => e.Id == id);
        }
    }
}
