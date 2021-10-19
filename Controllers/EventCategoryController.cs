using CodingEvents1.Data;
using CodingEvents1.Models;
using CodingEvents1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EventCategoryCotroller
{
    private EventDbContext context;
    public EventsCategoryController(EventDbContext dbContext)
    {
        context = dbContext;
    }

    [HttpGet]
    public IActionResult Index()
    {

        List<EventCategory> categories = context.Categories.ToList();
        return View(categories);
    }
  
}
