using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnDemandCarWash.DTO
{
    public class UserUpdated
    {

        [Required(ErrorMessage = "Full Name is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }
        public string Address { get; set; }
    }
}
