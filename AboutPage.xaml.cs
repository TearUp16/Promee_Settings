namespace Settings_Promee;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void OnImage1Tapped(object sender, TappedEventArgs e)
    {

        var next = new MainPage();

        await Navigation.PushAsync(next);
    }
}