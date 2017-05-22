using GalacticTrader.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GalacticTrader
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

		    
		}

		public static void SetMainPage()
		{
		    Current.MainPage = new GalacticTrader.MainPage();
		}
	}
}
