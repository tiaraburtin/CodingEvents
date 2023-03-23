using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<string> Events = new List<string>();

        public IActionResult Index()
        { string AirTest = "Test Stuff";

            
            //Events.Add("Code With Pride");
            //Events.Add("Strange Loops");
            //Events.Add("Women Who Code");

            ViewBag.events = Events;

            ViewBag.balloon = AirTest;
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/Events/Add")]

        public IActionResult NewEvent(string name)
        {
            Events.Add(name);
            return Redirect("/Events");
                }


    }
}
