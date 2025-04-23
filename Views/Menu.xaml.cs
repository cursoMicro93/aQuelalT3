namespace aQuelalT3.Views;

public partial class Menu : ContentPage
{
	public Menu(String usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado "+usuario;

    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Dashboard());
    }
}