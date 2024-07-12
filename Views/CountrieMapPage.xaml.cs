using PMT21RestCountry.Models;
using System.Text;

namespace PMT21RestCountry.Views;

public partial class CountrieMapPage : ContentPage
{
    string _region = string.Empty;
	public CountrieMapPage(string region = "", string name = "")
	{
		InitializeComponent();
        _region = region;
        GetCountrie(region, name);

        
    }

    public async void GetCountrie(string region, string name)
    {
        var countriesList = await Controllers.ContriesController.GetCountries(region);
        Countries countries = countriesList.FirstOrDefault(x => x.name.official == name);

        FlagImage.Source = countries.flags.png;
        CoatOfArmsImage.Source = countries.coatOfArms.png;
        CurrencyLabel.Text = GetCurrenciesString(countries.currencies);
        CapitalLabel.Text = string.Join(", ", countries.capital);
        RegionLabel.Text = countries.region;
        SubregionLabel.Text = countries.subregion;
        LangugesLabel.Text = GetLanguagesString(countries.languages);
        PopulationLabel.Text = countries.population.ToString();
        LatLongLabel.Text = string.Join(", ", countries.latlng);
        GoogleMapsWebView.Source = countries.maps.googleMaps;
        nameCommon.Title = countries.name.common;
        nameOfficial.Text = countries.name.official;
    }

    private string GetCurrenciesString(Dictionary<string, Currency> currencies)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var currency in currencies)
        {
            sb.AppendLine($"{currency.Value.name} ({currency.Key}) - Symbol: {currency.Value.symbol}");
        }

        return sb.ToString().Trim();
    }

    private string GetLanguagesString(Dictionary<string, string> languages)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var lang in languages)
        {
            sb.AppendLine($"({lang.Key.ToString()}) {lang.Value.ToString()}");
        }

        return sb.ToString().Trim();
    }
}