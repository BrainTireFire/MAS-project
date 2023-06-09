﻿using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string Country { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 4)]
        public string Password { get; set; }

    }
}
