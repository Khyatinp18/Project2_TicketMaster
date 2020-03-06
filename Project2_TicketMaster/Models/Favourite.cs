using System;
using System.Collections.Generic;

namespace Project2_TicketMaster.Models
{
    public partial class Favourite
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string EventType { get; set; }
        public string Url { get; set; }
        public string Locale { get; set; }

        public virtual AspNetUsers Owner { get; set; }
    }
}
