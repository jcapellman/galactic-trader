using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}