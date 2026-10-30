namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	private void Sobre_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Sobre());
	}
}