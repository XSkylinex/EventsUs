using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EventsUs.Models
{
    public class ApplicationUser : IdentityUser {

        [PersonalData]
        [Display(Name = "User name")]
        public string Name { get; set; }
        [NotMapped]
        [PersonalData]
        public bool isAdmin { get; set; }
        [PersonalData]
        public int Age { get; set; }
        [PersonalData]
        public string Country { get; set; }
        [PersonalData]
        public byte[] AvatarImage { get; set; }

    }
}
