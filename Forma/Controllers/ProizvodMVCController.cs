using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forma.Data;
using Forma.Data.Model;

namespace Forma.Controllers
{
    public class ProizvodMVCController : Controller
    {
        private readonly Context _context;

        public ProizvodMVCController(Context context)
        {
            _context = context;
        }

        // GET: ProizvodMVC
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proizvodi.ToListAsync());
        }

        // GET: ProizvodMVC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodModel = await _context.Proizvodi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (proizvodModel == null)
            {
                return NotFound();
            }

            return View(proizvodModel);
        }

        // GET: ProizvodMVC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProizvodMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Cijena,ID")] ProizvodModel proizvodModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proizvodModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proizvodModel);
        }

        // GET: ProizvodMVC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodModel = await _context.Proizvodi.FindAsync(id);
            if (proizvodModel == null)
            {
                return NotFound();
            }
            return View(proizvodModel);
        }

        // POST: ProizvodMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Cijena,ID")] ProizvodModel proizvodModel)
        {
            if (id != proizvodModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proizvodModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProizvodModelExists(proizvodModel.ID))
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
            return View(proizvodModel);
        }

        // GET: ProizvodMVC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodModel = await _context.Proizvodi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (proizvodModel == null)
            {
                return NotFound();
            }

            return View(proizvodModel);
        }

        // POST: ProizvodMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proizvodModel = await _context.Proizvodi.FindAsync(id);
            _context.Proizvodi.Remove(proizvodModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProizvodModelExists(int id)
        {
            return _context.Proizvodi.Any(e => e.ID == id);
        }
    }
}
