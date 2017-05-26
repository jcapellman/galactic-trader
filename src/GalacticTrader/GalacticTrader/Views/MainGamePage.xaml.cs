using GalacticTrader.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalacticTrader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainGamePage : TabbedPage
    {
        public MainGamePage ()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}