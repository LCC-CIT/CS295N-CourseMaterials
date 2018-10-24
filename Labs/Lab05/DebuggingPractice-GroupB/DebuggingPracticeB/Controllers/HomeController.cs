
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTown(string state, string town)
        {
            string content = "State: " + state + ", City: " + town;
            return Content(content);
        }

        [HttpPost]
        public IActionResult FavoriteMusic(string genre, string author, string book)
        {
            return Content("Genre: " + genre + ", Author: " + book + ", Book: " + author);
        }

        [HttpPost]
        public IActionResult Vacation(string location, string activity, string clothing)
        {
            string content = "Location: " + location + ", Activity: " + activity + ", What to wear: " + clothing;
            return Content("content");
        }

    }

}
