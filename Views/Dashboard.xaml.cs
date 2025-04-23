namespace aQuelalT3.Views;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}

    private void btnGurdar_Clicked(object sender, EventArgs e)
    {
		string usuarioC = txtUsuario.Text;
		string contraseniaC = txtContrasenia.Text;
		DisplayAlert("Alerta", "Usuario almacenado", "ok");
		Navigation.PushAsync(new Views.Home(usuarioC, contraseniaC));

    }
}