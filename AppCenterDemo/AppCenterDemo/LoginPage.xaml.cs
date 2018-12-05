using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenterDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
            {
                Analytics.TrackEvent("Login successful!");
                this.Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Oops!", "Login failed. Incorrect username or password", "OK");
                Analytics.TrackEvent("Login failed. Incorrect username or password.");
            }
        }
    }
}