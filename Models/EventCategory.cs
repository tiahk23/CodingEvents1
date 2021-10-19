using System.Collections.Generic;

namespace CodingEvents1.Models
{
    public class EventCategory
	{
		public string Name { get; set; }

		public int Id { get; set; }

		public List<Event> events { get; set; }

		public EventCategory()
		{
		}

		public EventCategory(string name)
		{
			Name = name;
		}

    }
}
