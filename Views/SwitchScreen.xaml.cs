using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchScreen : ContentPage
	{
		public SwitchScreen ()
		{
			InitializeComponent ();
		}

        override protected bool OnBackButtonPressed()
        {
            App.Current.MainPage = new DeviceMenuScreen();
            return true;

        }
    }
}