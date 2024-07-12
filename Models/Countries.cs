
namespace PMT21RestCountry.Models
{
   
    public class Countries
    {
        public Countries()
        {
            this.flags = new Flags();
            this.name = new Name();
            this.maps = new Maps();
            this.latlng = new List<decimal>();
        }
        public Name name { get; set; }
        public string region { get; set; } = string.Empty;
        public string subregion { get; set; } = string.Empty;
        public Flags flags { get; set; }
        public CoatOfArms coatOfArms { get; set; }
        public Dictionary<string, Currency> currencies { get; set; }
        public Dictionary<string, string> languages { get; set; }
        public List<string> capital { get; set; }
        public List<decimal> latlng { get; set; } 
        public Maps maps {  get; set; }
        public int population { get; set; }
    }

    public class Flags
    {
        public string png { get; set; } = string.Empty;
        public string svg { get; set; } = string.Empty;
    }
    public class CoatOfArms
    {
        public string png { get; set; } = string.Empty;
    }
    public class Currency
    {
        public string name { get; set; } = string.Empty;
        public string symbol { get; set; } = string.Empty;
    }
    public class Name
    {
        public string common { get; set; } = string.Empty;
        public string official { get; set; } = string.Empty;
    }

    public class Maps
    {
        public string googleMaps { get; set; } = string.Empty;
        public string openStreetMaps { get; set; } = string.Empty;
    }
}
