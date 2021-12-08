using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnitHub.Models;
using KnitHub.ViewModels;

namespace KnitHub.Controllers
{
    public class YarnDetailController : Controller
    {
        private readonly KnitHubContext _context;

        public YarnDetailController(KnitHubContext context)
        {
            _context = context;
        }

        // 12.8.21 Add conditional to check ViewBag for 2nd pass thru Index
        // GET: YarnDetail
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.YarnDetails.Include(y => y.Yarn);

            if (ViewBag.ID == null)
            {
                ViewBag.ID = TempData["id"].ToString();
                ViewBag.Producer = TempData["producer"].ToString();
                ViewBag.Name = TempData["name"].ToString();
            }

            return View(await knitHubContext.ToListAsync());
        }

        /*
        // GET: YarnDetail
        public async Task<IActionResult> Index()
        {
            var knitHubContext = _context.YarnDetails.Include(y => y.Yarn);

            ViewBag.ID = TempData["id"].ToString();
            ViewBag.Producer = TempData["producer"].ToString();
            ViewBag.Name = TempData["name"].ToString();

            return View(await knitHubContext.ToListAsync());
        }
        */

        public static YarnDetail GetYeOldeYarnDetails(KnitHubContext context, int? yarnDetailsID)
        {
            var yarnDetailObject = context.YarnDetails.FirstOrDefault(x => x.YarnDetailId == yarnDetailsID);

            yarnDetailObject.Yarn = context.Yarn.FirstOrDefault(x => x.YarnId == yarnDetailObject.YarnId);

            yarnDetailObject.Yarn.Manufacturer =
                context.Manufacturers.FirstOrDefault(x => x.ManufacturerId == context.Yarn.FirstOrDefault(d => d.YarnId == yarnDetailObject.Yarn.YarnId).ManufacturerId);

            yarnDetailObject.Yarn.FiberType =
                context.FiberTypess.FirstOrDefault(x => x.FiberTypeId == context.Yarn.FirstOrDefault(d => d.YarnId == yarnDetailObject.Yarn.YarnId).FiberTypeId);

            yarnDetailObject.Yarn.FiberWeight =
                context.FiberWeights.FirstOrDefault(x => x.FiberWeightId == context.Yarn.FirstOrDefault(d => d.YarnId == yarnDetailObject.Yarn.YarnId).FiberWeightId);

            return yarnDetailObject;
        }

        // 11-27-21 Display ViewModel Props
        // GET: YarnDetail/Details/5
        public ViewResult Details(int? ID)
        {
            var collectionID = ID;

            YarnDetail yarnDetail = GetYeOldeYarnDetails(_context, ID);

            YarnCollectionViewModel yarnCollectionViewModel = new YarnCollectionViewModel
            {
                Yarn = yarnDetail.Yarn,
                YarnDetail = yarnDetail
            };

            if (collectionID == yarnDetail.YarnDetailId)
            {

                ViewBag.collectionID = collectionID;
            }

            ViewBag.totalYardage = yarnDetail.CalcTotalYardage();

            return View(yarnCollectionViewModel);
        }

        // GET: YarnDetail/Create
        public IActionResult Create()
        {
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name");
            return View();
        }

        // 12.8.21 Grab data for ViewBag to populate Index
        // POST: YarnDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YarnDetailId,YarnId,YarnColor,YarnColorCode,YarnColorLot,QuantityOfSkeins,DateUpdated")] YarnDetail yarnDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yarnDetail);
                await _context.SaveChangesAsync();

                ViewBag.ID = yarnDetail.YarnId;
                ViewBag.Producer = yarnDetail.Yarn.Manufacturer.Name;
                ViewBag.Name = yarnDetail.Yarn.Name;

                return RedirectToAction(nameof(Index));
            }
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);

            ViewBag.ID = yarnDetail.YarnId;
            ViewBag.Producer = yarnDetail.Yarn.Manufacturer.Name;
            ViewBag.Name = yarnDetail.Yarn.Name;

            return View(yarnDetail);
        }

        /*
        // POST: YarnDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YarnDetailId,YarnId,YarnColor,YarnColorCode,YarnColorLot,QuantityOfSkeins,DateUpdated")] YarnDetail yarnDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yarnDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }
        */

        // GET: YarnDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarnDetail = await _context.YarnDetails.FindAsync(id);
            if (yarnDetail == null)
            {
                return NotFound();
            }
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }

        // POST: YarnDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("YarnDetailId,YarnId,YarnColor,YarnColorCode,YarnColorLot,QuantityOfSkeins,DateUpdated")] YarnDetail yarnDetail)
        {
            if (id != yarnDetail.YarnDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yarnDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YarnDetailExists(yarnDetail.YarnDetailId))
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
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }

        // GET: YarnDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarnDetail = await _context.YarnDetails
                .Include(y => y.Yarn)
                .FirstOrDefaultAsync(m => m.YarnDetailId == id);
            if (yarnDetail == null)
            {
                return NotFound();
            }

            return View(yarnDetail);
        }

        // POST: YarnDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yarnDetail = await _context.YarnDetails.FindAsync(id);
            _context.YarnDetails.Remove(yarnDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YarnDetailExists(int id)
        {
            return _context.YarnDetails.Any(e => e.YarnDetailId == id);
        }
    }
}
