//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Lalit_Pant_Dot_Net_Assignment.Data;
//using Lalit_Pant_Dot_Net_Assignment.Models;

//namespace Lalit_Pant_Dot_Net_Assignment.Controllers
//{
//    public class emergencyacceptersController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public emergencyacceptersController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: emergencyaccepters
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.emergencyaccepter.ToListAsync());
//        }

//        // GET: emergencyaccepters/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var emergencyaccepter = await _context.emergencyaccepter
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (emergencyaccepter == null)
//            {
//                return NotFound();
//            }

//            return View(emergencyaccepter);
//        }

//        // GET: emergencyaccepters/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: emergencyaccepters/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate")] emergencyaccepter emergencyaccepter)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(emergencyaccepter);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(emergencyaccepter);
//        }

//        // GET: emergencyaccepters/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var emergencyaccepter = await _context.emergencyaccepter.FindAsync(id);
//            if (emergencyaccepter == null)
//            {
//                return NotFound();
//            }
//            return View(emergencyaccepter);
//        }

//        // POST: emergencyaccepters/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate")] emergencyaccepter emergencyaccepter)
//        {
//            if (id != emergencyaccepter.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(emergencyaccepter);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!emergencyaccepterExists(emergencyaccepter.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(emergencyaccepter);
//        }

//        // GET: emergencyaccepters/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var emergencyaccepter = await _context.emergencyaccepter
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (emergencyaccepter == null)
//            {
//                return NotFound();
//            }

//            return View(emergencyaccepter);
//        }

//        // POST: emergencyaccepters/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var emergencyaccepter = await _context.emergencyaccepter.FindAsync(id);
//            if (emergencyaccepter != null)
//            {
//                _context.emergencyaccepter.Remove(emergencyaccepter);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool emergencyaccepterExists(int id)
//        {
//            return _context.emergencyaccepter.Any(e => e.Id == id);
//        }
//    }
//}



using Lalit_Pant_Dot_Net_Assignment.Data;
using Lalit_Pant_Dot_Net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lalit_Pant_Dot_Net_Assignment.Controllers
{
    public class emergencyacceptersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public emergencyacceptersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: emergencyaccepters
        public async Task<IActionResult> Index()
        {
            return View(await _context.emergencyaccepter.ToListAsync());
        }

        // GET: emergencyaccepters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyaccepter = await _context.emergencyaccepter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emergencyaccepter == null)
            {
                return NotFound();
            }

            return View(emergencyaccepter);
        }

        // GET: emergencyaccepters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: emergencyaccepters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate,Contact")] emergencyaccepter emergencyaccepter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergencyaccepter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emergencyaccepter);
        }

        // GET: emergencyaccepters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyaccepter = await _context.emergencyaccepter.FindAsync(id);
            if (emergencyaccepter == null)
            {
                return NotFound();
            }
            return View(emergencyaccepter);
        }

        // POST: emergencyaccepters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PatientName,BloodTypeRequired,Quantity,RequestDate,Contact")] emergencyaccepter emergencyaccepter)
        {
            if (id != emergencyaccepter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergencyaccepter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!emergencyaccepterExists(emergencyaccepter.Id))
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
            return View(emergencyaccepter);
        }

        // GET: emergencyaccepters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyaccepter = await _context.emergencyaccepter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emergencyaccepter == null)
            {
                return NotFound();
            }

            return View(emergencyaccepter);
        }

        // POST: emergencyaccepters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergencyaccepter = await _context.emergencyaccepter.FindAsync(id);
            if (emergencyaccepter != null)
            {
                _context.emergencyaccepter.Remove(emergencyaccepter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool emergencyaccepterExists(int id)
        {
            return _context.emergencyaccepter.Any(e => e.Id == id);
        }
    }
}
