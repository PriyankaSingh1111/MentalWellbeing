using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthWellBeing.Models;
using HealthWellBeing.Services;
using HealthWellBeing.ViewModels;
using Plugin.InputKit.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthWellBeing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionList : ContentView
	{

        public IList<QuestionAnwer> lstQuestionsSelected { get; set; }
        public IList<int> selectedOption { get; set; }
        public QuestionList ()
		{

            InitializeComponent();
            lstQuestionsSelected = new List<QuestionAnwer>();
        }
        public void OnButtonClicked(object sender, EventArgs args)
        {
            CSingleTone.Instance.addwellIdeas((Convert.ToString((sender as RadioButton).Value)), (sender as RadioButton).IsChecked);
            //QuestionAnwer QA = new QuestionAnwer();
            //RadioButton rb = (RadioButton)sender;
            //QA.QuestionId =int.Parse(rb.Value.ToString());

            //Application.Current.MainPage.DisplayAlert(rb.Text, QA.QuestionId.ToString(), "OK");
            //lstQuestionsSelected.Add(QA);


        }
    }
}