using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult CheckFever()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CheckFever(double temperature)
        {
            if (temperature >= 0)
            {
                ViewBag.Msg = Doctor.CheckFever(temperature);
                return View();
            }
            else
            {
                ViewBag.Msg = "Enter your temperature and then hit submit.";
                return View();
            }
        }
    }
}
