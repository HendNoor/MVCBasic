using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GuessingController : Controller
    {
        

        public IActionResult Guess()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetInt32("number").ToString()))
            {
                //Create session and store random number in it
                int generated = GuessingGame.GenerateNewNumber();
                HttpContext.Session.SetInt32("number",generated);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Guess(int guessedNumber)
        {
            //Test if guess was correct. If so, restaret game. Test with session data
            ViewBag.Message = GuessingGame.GuessNumber(guessedNumber, (int)HttpContext.Session.GetInt32("number"));
            if (GuessingGame.attempts ==-1)
            {
                //Reset session (and variables)
                int generated = GuessingGame.GenerateNewNumber();
                HttpContext.Session.SetInt32("number", generated);
            }
            return View();
        }
    }
}
