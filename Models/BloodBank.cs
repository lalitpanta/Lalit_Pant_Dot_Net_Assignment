using System.ComponentModel.DataAnnotations;

namespace Lalit_Pant_Dot_Net_Assignment.Models
{
    public class BloodBank
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string Contact { get; set; }
    }
}
