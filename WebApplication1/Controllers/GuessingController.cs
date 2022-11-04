using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GuessingController : Controller
    {
        Random random = new Random();
        public int randomTarget { get; set; }

        public IActionResult GuessingGame()
        {
            randomTarget = random.Next(0, 100);

            if (HttpContext.Session.GetString("Number") == null)
            {
                HttpContext.Session.SetInt32("Number", randomTarget);
            }
            return View();
        }

        [HttpPost]
        public IActionResult GuessViews(int guessNumber)
        {
            int guessNum = HttpContext.Session.GetInt32("Number");

            //ViewBag.Msg = Models.GuessingGame.IsCorrectNo(guessNumber, guessNum);
            //if (GuessingGame.IsCorrect)
            //{
            //    HttpContext.Session.GetInt32("Number");
            //}

            return View();
        }
    }
}
