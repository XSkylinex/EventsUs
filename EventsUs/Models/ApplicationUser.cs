using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EventsUs.Models
{
    public class ApplicationUser : IdentityUser {


        [Display(Name = "User name")]
        public string Name { get; set; }
        [NotMapped]
        public bool isAdmin { get; set; }

        public int Age { get; set; }
        public string Country { get; set; }

        public byte[] AvatarImage { get; set; }

    }
}
