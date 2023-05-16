﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Xunit.Abstractions;

namespace OnDemandCarWash.DTO
{
    public class Createuser
    {
        [Required(ErrorMessage = "Full Name is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }
    }
}
