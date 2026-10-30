namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

	private async void Repo_Clicked(object sender, EventArgs e)
	{
		Uri uri = new Uri("https://github.com/talessilva1/MauiAppHotel");
		await Browser.Default.OpenAsync(uri);
	}
}