namespace Settings_Promee;

public partial class HelpPage : ContentPage
{
	public HelpPage()
	{
		InitializeComponent();
	}
    async void OnImage1Tapped(object sender, TappedEventArgs e)
    {

        var next = new MainPage();

        await Navigation.PushAsync(next);
    }
}