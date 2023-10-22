namespace Settings_Promee
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        async void OnImage1Tapped(object sender, TappedEventArgs e)
        {

            var next = new notifications();

            await Navigation.PushAsync(next);
        }
        private async void OnImage2Tapped(object sender, TappedEventArgs e)
        {

            var next = new LanguagePage();

            await Navigation.PushAsync(next);
        }
        private async void OnImage3Tapped(object sender, TappedEventArgs e)
        {

            var next = new AboutPage();

            await Navigation.PushAsync(next);
        }
        private async void OnImage4Tapped(object sender, TappedEventArgs e)
        {

            var next = new HelpPage();

            await Navigation.PushAsync(next);
        }
    }
}