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
	public partial class DeviceMenuScreen : ContentPage
	{
		public DeviceMenuScreen ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        void ACPressed(Object sender, EventArgs e)
        {
            App.Current.MainPage = new AirConditionerScreen();
        }

        void LightsPressed(Object sender, EventArgs e)
        {
            App.Current.MainPage = new SwitchScreen();
        }

        void TVPressed(Object sender, EventArgs e)
        {
            App.Current.MainPage = new TvScreen();
        }

        void DoorLockPressed(Object sender, EventArgs e)
        {
            App.Current.MainPage = new SwitchScreen();
        }
        override protected bool OnBackButtonPressed()
        {
            App.Current.MainPage = new LoginScreen();
            return true;
            
        }
    }
}