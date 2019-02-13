using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using try2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginScreen : ContentPage
	{
		public LoginScreen ()
		{
			InitializeComponent ();
		}

        void SignInFunc(Object sender, EventArgs e)
        {
            User user = new User(Entry_Email.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                //DisplayAlert("Login", "Login Succeeded", "Oke");
                Application.Current.MainPage = new DeviceMenuScreen();
                
                
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Oke");

            }

        }

    }
}