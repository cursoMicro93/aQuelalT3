namespace aQuelalT3.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

	}
    string usuarioF = "";
    string contraseniaF = "";
    public Home(string usuarioC, string contraseniaC)
    {
        InitializeComponent();
        this.usuarioF = usuarioC;
        this.contraseniaF=contraseniaC;
    }
  
    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuarioF && txtContrasenia.Text == contraseniaF)
        {
            Navigation.PushAsync(new Views.Menu(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta","Usuario/Contrasenia incorrectos","ok");
            txtUsuario.Focus();
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Dashboard());
    }
}