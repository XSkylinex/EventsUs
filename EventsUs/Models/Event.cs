using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
