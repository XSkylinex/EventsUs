using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace EventsUs.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public string Location { get; set; }
        public List<User> UsersList = new List<User>();
        public bool PublicEvent { set; get; }
        public string YoutubeId { get; set; }
        public string adminId { get; set; }

    }
}
