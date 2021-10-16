﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnitHub.Models;

namespace KnitHub.Controllers
{
    public class PatternController : Controller
    {
        private readonly KnitHubContext _context;

        public PatternController(KnitHubContext context)
        {
            _context = context;
        }

        // GET: Pattern
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.Patterns.Include(p => p.Category).Include(p => p.Designer).Include(p => p.Manufacturer).Include(p => p.SkillLevel);
            return View(await knitHubContext.ToListAsync());
        }

        // GET: Pattern/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pattern = await _context.Patterns
                .Include(p => p.Category)
                .Include(p => p.Designer)
                .Include(p => p.Manufacturer)
                .Include(p => p.SkillLevel)
                .FirstOrDefaultAsync(m => m.PatternId == id);
            if (pattern == null)
            {
                return NotFound();
            }

            return View(pattern);
        }

        // GET: Pattern/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name");
            ViewData["DesignerId"] = new SelectList(_context.Designers, "DesignerId", "LastName");
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name");
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "SkillLevelId", "Level");
            return View();
        }

        // POST: Pattern/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatternId,Name,ManufacturerId,DesignerId,CategoryId,SkillLevelId,StorageLocation,DateUpdated")] Pattern pattern)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pattern);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", pattern.CategoryId);
            ViewData["DesignerId"] = new SelectList(_context.Designers, "DesignerId", "LastName", pattern.DesignerId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", pattern.ManufacturerId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "SkillLevelId", "Level", pattern.SkillLevelId);
            return View(pattern);
        }

        // GET: Pattern/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pattern = await _context.Patterns.FindAsync(id);
            if (pattern == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", pattern.CategoryId);
            ViewData["DesignerId"] = new SelectList(_context.Designers, "DesignerId", "LastName", pattern.DesignerId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", pattern.ManufacturerId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "SkillLevelId", "Level", pattern.SkillLevelId);
            return View(pattern);
        }

        // POST: Pattern/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatternId,Name,ManufacturerId,DesignerId,CategoryId,SkillLevelId,StorageLocation,DateUpdated")] Pattern pattern)
        {
            if (id != pattern.PatternId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pattern);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatternExists(pattern.PatternId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", pattern.CategoryId);
            ViewData["DesignerId"] = new SelectList(_context.Designers, "DesignerId", "LastName", pattern.DesignerId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", pattern.ManufacturerId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "SkillLevelId", "Level", pattern.SkillLevelId);
            return View(pattern);
        }

        // GET: Pattern/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pattern = await _context.Patterns
                .Include(p => p.Category)
                .Include(p => p.Designer)
                .Include(p => p.Manufacturer)
                .Include(p => p.SkillLevel)
                .FirstOrDefaultAsync(m => m.PatternId == id);
            if (pattern == null)
            {
                return NotFound();
            }

            return View(pattern);
        }

        // POST: Pattern/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pattern = await _context.Patterns.FindAsync(id);
            _context.Patterns.Remove(pattern);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatternExists(int id)
        {
            return _context.Patterns.Any(e => e.PatternId == id);
        }
    }
}
