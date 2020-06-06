using HealthWellBeing.Services;
using HealthWellBeing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthWellBeing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WellBeingIdeasPage : ContentPage
	{
		public WellBeingIdeasPage ()
		{
			InitializeComponent ();
            this.BindingContext = new UserViewModel();
        }

        public void OnButtonClicked(object sender, EventArgs args)
        {
            //DisplayAlert("Sucessful", "Thank you", "ok");
            //var uri = new Uri("https://web-chat.global.assistant.watson.cloud.ibm.com/preview.html?region=us-east&integrationID=a154e264-8d2a-4efd-8238-02ca836ad232&serviceInstanceID=714b7d0e-acaf-4c7f-b83d-0260061dc031");
            //Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            var res = CSingleTone.Instance.GetwellIdeas();
            DisplayAlert("Alert", "Please select part details to save.", "OK");

        }
        }
    }