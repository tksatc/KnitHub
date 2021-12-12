using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnitHub.Models;
using Microsoft.AspNetCore.Authorization;

namespace KnitHub.Controllers
{
    [Authorize]
    public class DesignerController : Controller
   {
        private readonly KnitHubContext _context;

        public DesignerController(KnitHubContext context)
        {
            _context = context;
        }

        // GET: Designer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Designers.ToListAsync());
        }

        // GET: Designer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers
                .FirstOrDefaultAsync(m => m.DesignerId == id);
            if (designer == null)
            {
                return NotFound();
            }

            return View(designer);
        }

        // GET: Designer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DesignerId,FirstName,LastName")] Designer designer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(designer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(designer);
        }

        // GET: Designer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers.FindAsync(id);
            if (designer == null)
            {
                return NotFound();
            }
            return View(designer);
        }

        // POST: Designer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DesignerId,FirstName,LastName")] Designer designer)
        {
            if (id != designer.DesignerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(designer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesignerExists(designer.DesignerId))
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
            return View(designer);
        }

        // GET: Designer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designer = await _context.Designers
                .FirstOrDefaultAsync(m => m.DesignerId == id);
            if (designer == null)
            {
                return NotFound();
            }

            return View(designer);
        }

        // POST: Designer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var designer = await _context.Designers.FindAsync(id);
            _context.Designers.Remove(designer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesignerExists(int id)
        {
            return _context.Designers.Any(e => e.DesignerId == id);
        }
    }
}
