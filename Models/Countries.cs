
namespace PMT21RestCountry.Models
{
    public class Countries
    {
        public string name { get; set; } = string.Empty;
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; } = string.Empty;
        public string alpha3Code { get; set; } = string.Empty;
        public List<string> callingCodes { get; set; }
        public string capital { get; set; } = string.Empty;
        public List<string> altSpellings { get; set; }
        public string region { get; set; } = string.Empty;
    }
}
