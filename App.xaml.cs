namespace aQuelalT3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //Navigationpage para navegacion
            return new Window(new NavigationPage(new Views.Home()));
        }
    }
}