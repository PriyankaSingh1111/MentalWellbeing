using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthWellBeing.Services;
using HealthWellBeing.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthWellBeing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HealthWellBeingPage : ContentPage
	{
		public HealthWellBeingPage()
		{
			InitializeComponent();
            this.BindingContext = new QuestionnaireViewModel ();

            Plugin.InputKit.Shared.Controls.RadioButton.GlobalSetting.BorderColor = Color.Black;

        }
        public void OnButtonClicked(object sender, EventArgs args)
        {
            var res = CSingleTone.Instance.GetwellIdeas();

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            // int[] list = res.;
            for (int i = 0; i < res.Count; i++)
            {
                if (int.Parse(res[i].ToString()) == 1)
                {
                    count1++;
                }

                else if (int.Parse(res[i].ToString()) == 2)
                {
                    count2++;
                }
                else if (int.Parse(res[i].ToString()) == 3)
                {
                    count3++;
                }
               
            }
            if (count3 >3)
                DisplayAlert("Hi,", "It looks like you are upset, do u need asistance?", "ok");
            else
            {
                DisplayAlert("Hi,", "Thank you for submitting your response", "ok");
            }
        }

    }
}