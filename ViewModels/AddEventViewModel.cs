using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid contact email address.")]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Location information is required.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Enter the number of attendees for your event (0 - 100,000)")]
        [Range (0, 100000)]
        public double NumberOfAttendees { get; set; }

    }
}
