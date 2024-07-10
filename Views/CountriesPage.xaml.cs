namespace PMT21RestCountry.Views;

public partial class CountriesPage : ContentPage
{
	public CountriesPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        Countries.ItemsSource = await Controllers.ContriesController.GetCountries();
    }

    private void Countries_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

    }
}