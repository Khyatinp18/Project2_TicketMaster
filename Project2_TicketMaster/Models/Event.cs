using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2_TicketMaster.Models
{

    public class EventRootobject
    {
        public _Embedded _embedded { get; set; }
        public _Links1 _links { get; set; }
        public Page page { get; set; }
    }

    public class _Embedded
    {
        public Attraction[] attractions { get; set; }
    }

    public class Attraction
    {
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string url { get; set; }
        public string locale { get; set; }
        public Externallinks externalLinks { get; set; }
        public string[] aliases { get; set; }
        public Image[] images { get; set; }
        public Classification[] classifications { get; set; }
        public Upcomingevents upcomingEvents { get; set; }
        public _Links _links { get; set; }
    }

    public class Externallinks
    {
        public Youtube[] youtube { get; set; }
        public Facebook[] facebook { get; set; }
        public Musicbrainz[] musicbrainz { get; set; }
        public Twitter[] twitter { get; set; }
        public Wiki[] wiki { get; set; }
        public Homepage[] homepage { get; set; }
        public Itune[] itunes { get; set; }
        public Lastfm[] lastfm { get; set; }
        public Instagram[] instagram { get; set; }
    }

    public class Youtube
    {
        public string url { get; set; }
    }

    public class Facebook
    {
        public string url { get; set; }
    }

    public class Musicbrainz
    {
        public string id { get; set; }
    }

    public class Twitter
    {
        public string url { get; set; }
    }

    public class Wiki
    {
        public string url { get; set; }
    }

    public class Homepage
    {
        public string url { get; set; }
    }

    public class Itune
    {
        public string url { get; set; }
    }

    public class Lastfm
    {
        public string url { get; set; }
    }

    public class Instagram
    {
        public string url { get; set; }
    }

    public class Upcomingevents
    {
        public int _total { get; set; }
        public int ticketmaster { get; set; }
        public int tmr { get; set; }
        public int mfxde { get; set; }
        public int mfxnl { get; set; }
        public int mfxes { get; set; }
        public int mfxpl { get; set; }
        public int mfxbe { get; set; }
        public int mfxat { get; set; }
        public int mfxdk { get; set; }
        public int mfxcz { get; set; }
        public int ticketweb { get; set; }
    }

    public class _Links
    {
        public Self self { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Image
    {
        public string ratio { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool fallback { get; set; }
        public string attribution { get; set; }
    }

    public class Classification
    {
        public bool primary { get; set; }
        public Segment segment { get; set; }
        public Genre genre { get; set; }
        public Subgenre subGenre { get; set; }
        public Type type { get; set; }
        public Subtype subType { get; set; }
        public bool family { get; set; }
    }

    public class Segment
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Genre
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Subgenre
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Type
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Subtype
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class _Links1
    {
        public First first { get; set; }
        public Self1 self { get; set; }
        public Next next { get; set; }
        public Last last { get; set; }
    }

    public class First
    {
        public string href { get; set; }
    }

    public class Self1
    {
        public string href { get; set; }
    }

    public class Next
    {
        public string href { get; set; }
    }

    public class Last
    {
        public string href { get; set; }
    }

    public class Page
    {
        public int size { get; set; }
        public int totalElements { get; set; }
        public int totalPages { get; set; }
        public int number { get; set; }
    }

}
