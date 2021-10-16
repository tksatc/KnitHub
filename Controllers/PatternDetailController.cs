using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnitHub.Models;

namespace KnitHub.Controllers
{
    public class PatternDetailController : Controller
    {
        private readonly KnitHubContext _context;

        public PatternDetailController(KnitHubContext context)
        {
            _context = context;
        }

        // GET: PatternDetail
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.PatternDetails.Include(p => p.Pattern);
            return View(await knitHubContext.ToListAsync());
        }

        // GET: PatternDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternDetail = await _context.PatternDetails
                .Include(p => p.Pattern)
                .FirstOrDefaultAsync(m => m.PatternDetailId == id);
            if (patternDetail == null)
            {
                return NotFound();
            }

            return View(patternDetail);
        }

        // GET: PatternDetail/Create
        public IActionResult Create()
        {
            ViewData["PatternId"] = new SelectList(_context.Patterns, "PatternId", "Name");
            return View();
        }

        // POST: PatternDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatternDetailId,PatternId,yarnWeightKey,yarnWeightValue,needleTypeKey,needleTypeValue,needleSizeKey,needleSizeValue,wearableSizeKey,wearableSizeValue")] PatternDetail patternDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patternDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatternId"] = new SelectList(_context.Patterns, "PatternId", "Name", patternDetail.PatternId);
            return View(patternDetail);
        }

        // GET: PatternDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternDetail = await _context.PatternDetails.FindAsync(id);
            if (patternDetail == null)
            {
                return NotFound();
            }
            ViewData["PatternId"] = new SelectList(_context.Patterns, "PatternId", "Name", patternDetail.PatternId);
            return View(patternDetail);
        }

        // POST: PatternDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatternDetailId,PatternId,yarnWeightKey,yarnWeightValue,needleTypeKey,needleTypeValue,needleSizeKey,needleSizeValue,wearableSizeKey,wearableSizeValue")] PatternDetail patternDetail)
        {
            if (id != patternDetail.PatternDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patternDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatternDetailExists(patternDetail.PatternDetailId))
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
            ViewData["PatternId"] = new SelectList(_context.Patterns, "PatternId", "Name", patternDetail.PatternId);
            return View(patternDetail);
        }

        // GET: PatternDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patternDetail = await _context.PatternDetails
                .Include(p => p.Pattern)
                .FirstOrDefaultAsync(m => m.PatternDetailId == id);
            if (patternDetail == null)
            {
                return NotFound();
            }

            return View(patternDetail);
        }

        // POST: PatternDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patternDetail = await _context.PatternDetails.FindAsync(id);
            _context.PatternDetails.Remove(patternDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatternDetailExists(int id)
        {
            return _context.PatternDetails.Any(e => e.PatternDetailId == id);
        }
    }
}
