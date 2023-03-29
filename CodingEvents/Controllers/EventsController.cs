using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
//<<<<<<< Updated upstream
        static private Dictionary<string, string> Events = new Dictionary<string, string>();
//=======
        static private List<Event> events = new List<Event>();
//>>>>>>> Stashed changes

        // GET: /<controller>/
        public IActionResult Index()
        {
            // GET: /<controller>/
                List<Event> events = new List<Event>(EventData.GetAll());

                return View(events);
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string desc = "")
        {
//<<<<<<< Updated upstream
            Events.Add(name, desc);
//=======
            Events.Add(new Event(name));
//>>>>>>> Stashed changes

            return Redirect("/Events");
		}

        [Route("/Events/Edit/{eventId}")]
        [HttpGet]
		public IActionResult Edit(int eventId)
		{
            // controller code will go here
            //Event EditEvent = EventData.GetById(eventId);
            //ViewBag.editEvent = EditEvent;
            return View();
		}
        [Route ("/Events/Edit")]
		[HttpPost]
		public IActionResult SubmitEditEventForm(int eventId, string name, string description)
		{
            // controller code will go here
            return Redirect("/Events");
		}
	}
}

