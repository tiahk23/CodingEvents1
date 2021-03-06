using CodingEvents1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents1.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Please stay below a maxium description length is 500.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage ="Category is required")]
        public int CategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; }

       public AddEventViewModel(List<EventCategory> Categories)
        {
            Categories = new List<SelectListItem>();

            foreach (var category in Categories)
            {
                Categories.Add(
                    new SelectListItem
                    {
                        Value = category.Id.ToString(),
                        Text = category.Name
                    }
                    );
            }
        }

        public AddEventViewModel() { }
    }
}
