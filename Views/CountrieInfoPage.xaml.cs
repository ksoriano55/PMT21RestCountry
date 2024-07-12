namespace PMT21RestCountry.Views;

public partial class CountrieInfoPage : ContentPage
{
    public CountrieInfoPage()
    {
        InitializeComponent();

        var mapUrl = "https://www.google.com/maps/place/Rep%C3%BAblica+Dominicana/@18.6698995,-70.130055,8z/data=!3m1!4b1!4m6!3m5!1s0x8eaf8838def1b6f5:0xa6020f24060df7e0!8m2!3d18.735693!4d-70.162651!16zL20vMDI3cm4?entry=ttu";

        mapWebView.Source = mapUrl;
    }
}