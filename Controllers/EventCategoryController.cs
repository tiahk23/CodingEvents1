using System;


public class EventCategoryCotroller
{
    private EventDbContext context;
    public EventsCategoryController(EventDbContext dbContext)
    {
        context = dbContext;
    }


    public IActionResult Index()
    {
       
        return View(Index.cshtml);
    }
}
