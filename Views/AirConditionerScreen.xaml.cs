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
	public partial class AirConditionerScreen : ContentPage
	{
		public AirConditionerScreen ()
		{
			InitializeComponent ();
            
		}

        void PressedSend(Object sender, EventArgs e)
        {
            var mode = Picker_Mode.Items[Picker_Mode.SelectedIndex];
            var temp = Picker_Temp.Items[Picker_Temp.SelectedIndex];
            var power = Picker_Power.Items[Picker_Power.SelectedIndex];
            string mode_string = "Mode => " + mode.ToString();
            string temp_string = "Temperature => " + temp.ToString();
            string power_string = "Power => " + power.ToString();
            string result = mode_string + "\n" + temp_string + "\n" + power_string;
            DisplayAlert("Message Sent", result, "Oke");
        }
        override protected bool OnBackButtonPressed()
        {
            App.Current.MainPage = new DeviceMenuScreen();
            return true;

        }
    }
}