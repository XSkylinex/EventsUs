using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "YouTube link")]
        public string YoutubeId { get; set; }
        public string EventAdminId { get; set; }
        [Display(Name = "Public")]
        public bool PublicPrivate { get; set; }
        public int Predictpepole { get; set; }
        public int MLPredictpepole { get; set; }
        public int Realcome { get; set; }

    }
}
