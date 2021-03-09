using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlusSport.Ecommerce.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "Usernames must be valid email addresses!")]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "This password is too short!")]
        public string Password { get; set; }
    }
}