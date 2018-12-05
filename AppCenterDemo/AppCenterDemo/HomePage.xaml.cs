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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "meat");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "pasta");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "chicken");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "veggies");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "sandwich");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }
        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("category", "desserts");

            Analytics.TrackEvent("Recipes Visited", dictionary);
        }
    }
}