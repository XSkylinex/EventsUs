using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsUs.Models
{
    public class User:IdentityUser
    {

        public int age { get; set; }

        List<User> list_friednds = new List<User>();
        List<Event> list_events = new List<Event>();

    }
}
