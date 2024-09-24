using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private static List<LopHoc> danhSachLopHoc = new List<LopHoc>
        {
            new LopHoc { Id = 1, TenLopHoc = "CNTT", NamNhapHoc = 2020, NamRaTruong = 2024, SoLuongSinhVien = 100 },
            new LopHoc { Id = 2, TenLopHoc = "Kinh Te", NamNhapHoc = 2019, NamRaTruong = 2023, SoLuongSinhVien = 80 }
        };

        public IActionResult Index()
        {
            return View(danhSachLopHoc);
        }

        public IActionResult Details(int id)
        {
            var lopHoc = danhSachLopHoc.FirstOrDefault(l => l.Id == id);
            if (lopHoc == null) return NotFound();
            return View(lopHoc);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                lopHoc.Id = danhSachLopHoc.Max(l => l.Id) + 1;
                danhSachLopHoc.Add(lopHoc);
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        public IActionResult Edit(int id)
        {
            var lopHoc = danhSachLopHoc.FirstOrDefault(l => l.Id == id);
            if (lopHoc == null) return NotFound();
            return View(lopHoc);
        }

        [HttpPost]
        public IActionResult Edit(LopHoc lopHoc)
        {
            var existingLopHoc = danhSachLopHoc.FirstOrDefault(l => l.Id == lopHoc.Id);
            if (existingLopHoc == null) return NotFound();

            if (ModelState.IsValid)
            {
                existingLopHoc.TenLopHoc = lopHoc.TenLopHoc;
                existingLopHoc.NamNhapHoc = lopHoc.NamNhapHoc;
                existingLopHoc.NamRaTruong = lopHoc.NamRaTruong;
                existingLopHoc.SoLuongSinhVien = lopHoc.SoLuongSinhVien;
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        public IActionResult Delete(int id)
        {
            var lopHoc = danhSachLopHoc.FirstOrDefault(l => l.Id == id);
            if (lopHoc == null) return NotFound();
            return View(lopHoc);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var lopHoc = danhSachLopHoc.FirstOrDefault(l => l.Id == id);
            if (lopHoc != null)
            {
                danhSachLopHoc.Remove(lopHoc);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}