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
	public partial class TvScreen : ContentPage
	{
        bool on = true;
        int volume = 0;
        int channel = 0;

		public TvScreen ()
		{
			InitializeComponent ();
		}
        override protected bool OnBackButtonPressed()
        {
            App.Current.MainPage = new DeviceMenuScreen();
            return true;

        }

        void btnOnPressed(Object sender, EventArgs e)
        {
            on = true;
        }
        void btnOffPressed(Object sender, EventArgs e)
        {
            on = false;
        }

        void btnVloumePlusPressed(Object sender, EventArgs e)
        {
            volume++;
        }

        void btnVloumeMinusPressed(Object sender, EventArgs e)
        {
            volume--;
        }

        void btnChannelPlusPressed(Object sender, EventArgs e)
        {
            channel++;
        }

        void btnChannelMinusPressed(Object sender, EventArgs e)
        {
            channel--;
        }
    }

}