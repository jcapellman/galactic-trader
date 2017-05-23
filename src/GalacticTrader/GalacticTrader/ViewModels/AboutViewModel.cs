using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace GalacticTrader.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";

			OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://www.motionblurstudiosllc.com/galactic-trader")));
		}
        
		public ICommand OpenWebCommand { get; }
	}
}