using PMT21RestCountry.Models;
using System.Collections.ObjectModel;

namespace PMT21RestCountry.Views;

public partial class CountriesPage : ContentPage
{
    public ObservableCollection<string> Options { get; set; }
    public string SelectedOption { get; set; }
    public CountriesPage()
	{
		InitializeComponent();

        Options = new ObservableCollection<string>
            {
                "Europe",
                "America",
                "Asia",
                "Oceania",
                "Africa"
            };

        regions.SelectedIndexChanged += OnPickerSelectedIndexChanged;

        BindingContext = this;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        Countries.ItemsSource = await Controllers.ContriesController.GetCountries();
    }

    private async void OnPickerSelectedIndexChanged(object sender, System.EventArgs e)
    {
        if (regions.SelectedIndex != -1)
        {
            SelectedOption = Options[regions.SelectedIndex];
            OnPropertyChanged(nameof(SelectedOption));
            Countries.ItemsSource = await Controllers.ContriesController.GetCountries(SelectedOption);
        }
    }

    private void Countries_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var hola = "hola";
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var frame = sender as Frame;
        if (frame == null)
            return;

        var countrie = frame.BindingContext as Countries;
        VerInformacion(countrie);
    }

    private void VerInformacion(Countries countries)
    {
        SelectedOption = SelectedOption == null ? "America" : SelectedOption;
        CountrieMapPage countrieMapPage = new CountrieMapPage(SelectedOption, countries.name.official);
        Navigation.PushAsync(countrieMapPage);
    }
}