namespace GalacticTrader.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new GalacticTrader.App());
        }
    }
}