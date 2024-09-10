using Microsoft.AspNetCore.Mvc;

namespace BT02.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}