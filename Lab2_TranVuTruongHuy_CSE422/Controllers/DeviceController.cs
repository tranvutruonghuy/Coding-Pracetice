using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab2_TranVuTruongHuy_CSE422.Data;
using Lab2_TranVuTruongHuy_CSE422.Models;

namespace Lab2_TranVuTruongHuy_CSE422.Controllers
{
    public class DeviceController : Controller
    {
        private readonly DataContext _context;

        public DeviceController(DataContext context)
        {
            _context = context;
        }

        // GET: Device
        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View(await _context.Devices.ToListAsync());
        }

        // GET: Device/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.Devices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceModel == null)
            {
                return NotFound();
            }

            return View(deviceModel);
        }

        // GET: Device/Create
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: Device/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CategoryId,Status")] DeviceModel deviceModel)
        {
            if (ModelState.IsValid)
            { 
                DeviceModel device = new DeviceModel();
                device.Id = deviceModel.Id;
                device.Name = deviceModel.Name;
                device.CategoryId = deviceModel.CategoryId;
                device.Status = deviceModel.Status;
                device.EntryDate = DateTime.Now;

                _context.Add(deviceModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deviceModel);
        }

        // GET: Device/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.Devices.FindAsync(id);
            if (deviceModel == null)
            {
                return NotFound();
            }
            ViewBag.Categories = _context.Categories.ToList();
            return View(deviceModel);
        }

        // POST: Device/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CategoryId,Status")] DeviceModel deviceModel)
        {
            if (id != deviceModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DeviceModel device = new DeviceModel();
                    device.Id = deviceModel.Id;
                    device.Name = deviceModel.Name;
                    device.CategoryId = deviceModel.CategoryId;
                    device.Status = deviceModel.Status;
                    device.EntryDate = DateTime.Now;
                    _context.Update(deviceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeviceModelExists(deviceModel.Id))
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
            return View(deviceModel);
        }

        // GET: Device/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceModel = await _context.Devices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceModel == null)
            {
                return NotFound();
            }

            return View(deviceModel);
        }

        // POST: Device/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deviceModel = await _context.Devices.FindAsync(id);
            if (deviceModel != null)
            {
                _context.Devices.Remove(deviceModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceModelExists(int id)
        {
            return _context.Devices.Any(e => e.Id == id);
        }



        [HttpPost]
        [Route("FilterDevicesByCategory")]
        public async Task<IActionResult> FilterDevicesByCategory([FromBody] int categoryId)
        {
            var devices = await _context.Devices
                                        .Where(d => d.CategoryId == categoryId)
                                        .ToListAsync();
            return Json(devices);

        }
        [HttpPost]
        [Route("FilterDevicesByStatus")]
        public async Task<IActionResult> FilterDevicesByStatus([FromBody] string status)
        {
            var devices = await _context.Devices
                                        .Where(d => d.Status == status)
                                        .ToListAsync();
            return Json(devices);

        }
        [HttpPost]
        [Route("FilterDevicesByName")]
        public async Task<IActionResult> FilterDevicesByName([FromBody] string name)
        {
            var devices = await _context.Devices
                                        .Where(d => d.Name == name)
                                        .ToListAsync();
            return Json(devices);

        }
        [HttpPost]
        [Route("FilterDevicesByCode")]
        public async Task<IActionResult> FilterDevicesByCode([FromBody] int code)
        {
            var devices = await _context.Devices
                                        .Where(d => d.Id == code)
                                        .ToListAsync();
            return Json(devices);

        }
    }
}
