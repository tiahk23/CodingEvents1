﻿using CodingEvents1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents1.Controllers
{
    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = Events;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(new Event(name, description));
            return Redirect("/Events");
        }

    }
}
