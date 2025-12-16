using Microsoft.AspNetCore.Mvc;
using PresensiSiswa.Models;
using PresensiSiswa.Services;

namespace PresensiSiswa.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendanceService _service;

        // Dependency Injection
        public AttendanceController(IAttendanceService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Attendance attendance)
        {
            if (!ModelState.IsValid)
                return View(attendance);

            _service.Add(attendance);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return NotFound();
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Attendance attendance)
        {
            _service.Update(attendance);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return NotFound();
            return View(data);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
