using PMT21RestCountry.Views;

namespace PMT21RestCountry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new CountrieInfoPage());
            //MainPage = new NavigationPage(new CountrieMapPage());
        }
    }
}
