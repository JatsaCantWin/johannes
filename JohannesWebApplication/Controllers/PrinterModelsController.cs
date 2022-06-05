using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JohannesWebApplication.Data;
using JohannesWebApplication.Models;

namespace JohannesWebApplication.Controllers
{
    public class PrinterModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrinterModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PrinterModels
        public async Task<IActionResult> Index()
        {
              return _context.Printers != null ? 
                          View(await _context.Printers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Printers'  is null.");
        }

        public async Task<IActionResult> AddPrinter(int id)
        {
            var printerModel = await _context.Printers
                .FirstOrDefaultAsync(m => m.PrinterID == id);

            UserPrinter userPrinter = new UserPrinter
            {
                UserPrinterId = User.GetHashCode(),
                PrinterId = id
            };

            _context.Add(userPrinter);
            await _context.SaveChangesAsync();

            return View(printerModel);
        }

        // GET: PrinterModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printerModel = await _context.Printers
                .FirstOrDefaultAsync(m => m.PrinterID == id);
            if (printerModel == null)
            {
                return NotFound();
            }

            return View(printerModel);
        }

        // GET: PrinterModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrinterModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,SizeX,SizeY,SizeZ,Description")] PrinterModel printerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(printerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Content("Not Valid");
        }

        // GET: PrinterModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printerModel = await _context.Printers.FindAsync(id);
            if (printerModel == null)
            {
                return NotFound();
            }
            return View(printerModel);
        }

        // POST: PrinterModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrinterID,Name,SizeX,SizeY,SizeZ,Description")] PrinterModel printerModel)
        {
            if (id != printerModel.PrinterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(printerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrinterModelExists(printerModel.PrinterID))
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
            return View(printerModel);
        }

        // GET: PrinterModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printerModel = await _context.Printers
                .FirstOrDefaultAsync(m => m.PrinterID == id);
            if (printerModel == null)
            {
                return NotFound();
            }

            return View(printerModel);
        }

        // POST: PrinterModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Printers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Printers'  is null.");
            }
            var printerModel = await _context.Printers.FindAsync(id);
            if (printerModel != null)
            {
                _context.Printers.Remove(printerModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrinterModelExists(int id)
        {
          return (_context.Printers?.Any(e => e.PrinterID == id)).GetValueOrDefault();
        }
    }
}
