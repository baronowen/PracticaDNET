using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practicum_4__optie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String xmlString;
            using (WebClient wc = new WebClient())
            {
                xmlString = wc.DownloadString(@"http://ws.audioscrobbler.com/2.0/?method=album.getinfo&album=awake&artist=Dream%20Theater&api_key=b5cbf8dcef4c6acfc5698f8709841949");
            }
            XDocument myXmlDoc = XDocument.Parse(xmlString);
            //Console.WriteLine(myXmlDoc);

            CD cd1 = new CD();
            var titel = cd1.Titel = "Awake";
            var artiest = cd1.Artiest = "Dream Theater";

            List<Track> tracks = CreateTracks();

            var cdXml = new XDocument(new XElement("CD",
                new XAttribute("Artiest", artiest),
                new XAttribute("Titel", titel),
                new XElement("Tracks",
                from tr in tracks
                select new XElement("Track",
                    new XElement("Artiest", tr.Artiest),
                    new XElement("Titel", tr.Titel),
                    new XElement("Lengte", tr.Lengte.ToString("m':'ss"))
                    ))));
            Console.WriteLine("Eerste XML doc \n" + cdXml + "\n");

            var query =
                from tr in myXmlDoc.Root.Descendants("track")
                where !((from tr2 in cdXml.Descendants("Track")
                       where tr.Element("name").Value == tr2.Element("Titel").Value &&
                       tr.Element("artist").Element("name").Value == tr2.Element("Artiest").Value
                       select tr2).Any())

                select new Track
                {
                    Titel = (string)tr.Element("name"),
                    Lengte = TimeSpan.FromSeconds(Int32.Parse(tr.Element("duration").Value)),
                    Artiest = (string)tr.Element("artist").Element("name")
                };
            foreach(var tr in query)
            {
                Console.WriteLine(tr.Titel + " door: " + tr.Artiest + " " + tr.Lengte + "\n");
                var newTracks = new XElement("Track",
                    new XElement("Artiest", tr.Artiest),
                    new XElement("Titel", tr.Titel),
                    new XElement("Lengte", tr.Lengte.ToString("m':'ss")));
                cdXml.Descendants("Tracks").First().Add(newTracks);
            }
            Console.WriteLine(cdXml);
        }

        private static List<Track> CreateTracks()
        {
            List<Track> tracks = new List<Track>
            {
                new Track { Artiest = "Dream Theater",
                            Titel = "6:00",
                            Lengte = new TimeSpan(0,5,31) },
                new Track { Artiest = "Dream Theater",
                            Titel = "Caught in a Web",
                            Lengte = new TimeSpan(0,5,28) },
                new Track { Artiest = "Dream Theater",
                            Titel = "Innocence Faded",
                            Lengte = new TimeSpan(0,5,34) }
            };
            return tracks;
        }
    }

    class CD
    {
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public List<Track> Tracks { get; set; }

    }

    class Track
    {
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public TimeSpan Lengte { get; set; }

    }
}
