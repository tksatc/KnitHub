using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnitHub.Models;
using KnitHub.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace KnitHub.Controllers
{
    [Authorize]
    public class PatternDetailController : Controller
    {
        private readonly KnitHubContext _context;

        public PatternDetailController(KnitHubContext context)
        {
            _context = context;
        }


        // 12.8.21 Retrieving Data from PatternController
        // GET: PatternDetail
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.PatternDetails.Include(p => p.Pattern);

            if (ViewBag.ID == null)
            {
                ViewBag.ID = TempData["id"].ToString();
                ViewBag.Name = TempData["name"].ToString();
            }

            return View(await knitHubContext.ToListAsync());
        }

        /*
        // GET: PatternDetail
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.PatternDetails.Include(p => p.Pattern);
            return View(await knitHubContext.ToListAsync());
        }
        */


        // 12.8.21 - Create a PatternDetail Object for the Pattern VM
        public static PatternDetail GetPatternDetails(KnitHubContext context, int? patternDetailsID)
        {
            var patternDetailObject = context.PatternDetails.FirstOrDefault(x => x.PatternDetailId == patternDetailsID);

            patternDetailObject.Pattern = context.Patterns.FirstOrDefault(x => x.PatternId == patternDetailObject.PatternId);

            patternDetailObject.Pattern.Manufacturer =
                context.Manufacturers.FirstOrDefault(x => x.ManufacturerId == context.Patterns.FirstOrDefault(d => d.PatternId == patternDetailObject.Pattern.PatternId).ManufacturerId);

            patternDetailObject.Pattern.Category =
                context.Categories.FirstOrDefault(x => x.CategoryId == context.Patterns.FirstOrDefault(d => d.PatternId == patternDetailObject.Pattern.PatternId).CategoryId);
            
            patternDetailObject.Pattern.SkillLevel =
                context.SkillLevels.FirstOrDefault(x => x.SkillLevelId == context.Patterns.FirstOrDefault(d => d.PatternId == patternDetailObject.Pattern.PatternId).SkillLevelId);

            patternDetailObject.Pattern.Designer =
                context.Designers.FirstOrDefault(x => x.DesignerId == context.Patterns.FirstOrDefault(d => d.PatternId == patternDetailObject.Pattern.PatternId).DesignerId);

            return patternDetailObject;

        }

        // 12.8.21 - Display ViewModel Properties
        // GET: PatternDetail/Details/5
        public ViewResult Details(int? ID)
        {
            var specsID = ID;

            PatternDetail patternDetail = GetPatternDetails(_context, ID);

            PatternDetailsViewModel patternDetailsViewModel = new PatternDetailsViewModel
            {
                Pattern = patternDetail.Pattern,
                PatternDetail = patternDetail
            };

            patternDetailsViewModel.PatternDetail.wearableSizeValue = _context.WearableSizes.FirstOrDefault(x => x.WearableSizeId.ToString() == patternDetailsViewModel.PatternDetail.wearableSizeValue).Name;

            if (specsID == patternDetail.PatternDetailId)
            {
                ViewBag.specsID = specsID;
            }

            return View(patternDetailsViewModel);
        }

        /*
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
        */

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
