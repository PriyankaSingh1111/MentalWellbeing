using HealthWellBeing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.InputKit.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace HealthWellBeing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardViewTemplate : ContentView
	{
		public CardViewTemplate ()
		{
			InitializeComponent ();
		}
        private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Label link = (Label)sender;
            string fullPath = "";
            if (link.GestureRecognizers.Count > 0)
            {
                var gesture = (TapGestureRecognizer)link.GestureRecognizers[0];
                fullPath = (string)gesture.CommandParameter;
            }

            var uri = new Uri(fullPath);
           Browser.OpenAsync(fullPath, BrowserLaunchMode.SystemPreferred);
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            if ((sender as Plugin.InputKit.Shared.Controls.CheckBox).IsChecked)
            {
                // DisplayAlert("", "What a nice! You checked...", "OK");
              //  SelectedItem.Add(Convert.ToString((sender as CheckBox).CommandParameter));
                CSingleTone.Instance.addwellIdeas((Convert.ToString((sender as Plugin.InputKit.Shared.Controls.CheckBox).CommandParameter)), (sender as Plugin.InputKit.Shared.Controls.CheckBox).IsChecked);
            }
        }
    }
}