using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebPagesMvc.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [FromQuery]
        public string UserName { get; set; }

        [FromQuery]
        public string Password { get; set; }

        [FromQuery]
        public string Email { get; set; }

        [FromQuery]
        [Phone]
        public long? PhoneNumber { get; set; }

        [FromQuery]
        [Phone]
        public long? AlternatePhoneNumber { get; set; }

        [FromQuery]
        [MaxLength(255)]
        public string Address { get; set; }

        [FromQuery]
        public string FirstName { get; set; }

        [FromQuery]
        public string LastName { get; set; }

        [FromQuery]
        public bool AgreedToTerms { get; set; }

        [FromQuery]
        public long? AadharNumber { get; set; }
    }
}
