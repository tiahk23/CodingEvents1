using CodingEvents1.Data;
using CodingEvents1.Models;
using CodingEvents1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents1.Controllers
{
    public class EventsController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail
                };
                EventData.Add(newEvent);
                return Redirect("/Events");
            }
            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost] //responsible for post requests
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
            return Redirect("/Events");
        }

        [HttpPost]
        [Route("/Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            //controller code
            ViewBag.events = EventData.GetById(eventId);
            return View();
            
        }

        [HttpPost]
        [Route("/Events/Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            //controller code here
            ViewBag.eventToEdit = EventData.GetAll();
            return View();
        }
    }
}
