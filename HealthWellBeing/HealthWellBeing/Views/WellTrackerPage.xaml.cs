using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthWellBeing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WellTrackerPage : ContentPage
    {
        public WellTrackerPage()
        {
            InitializeComponent();
            MyLineChart.Chart = new DonutChart { Entries = _entries };
        }
        private readonly List<Microcharts.Entry> _entries = new List<Microcharts.Entry>()
        {
                new Microcharts.Entry(200)
            {
                Label = "January",
                ValueLabel = "200",
                Color = SKColor.Parse("#FF0033"),
            },
            new Microcharts.Entry(400)
            {
                Label = "February",
                ValueLabel = "400",
                Color = SKColor.Parse("#FF8000"),
            },
            new Microcharts.Entry(300)
            {
                Label = "March",
                ValueLabel = "300",
                Color = SKColor.Parse("#FFE600"),
            },
            new Microcharts.Entry(250)
            {
                Label = "April",
                ValueLabel = "250",
                Color = SKColor.Parse("#1AB34D"),
            },
            new Microcharts.Entry(650)
            {
                Label = "May",
                ValueLabel = "650",
                Color = SKColor.Parse("#1A66FF"),
            },
            new Microcharts.Entry(500)
            {
                Label = "June",
                ValueLabel = "500",
                Color = SKColor.Parse("#801AB3"),
            },
        };
        public void OnButtonClicked(object sender, EventArgs args)
        {
            var uri = new Uri("https://web-chat.global.assistant.watson.cloud.ibm.com/preview.html?region=us-east&integrationID=a154e264-8d2a-4efd-8238-02ca836ad232&serviceInstanceID=714b7d0e-acaf-4c7f-b83d-0260061dc031");
            Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        public void OnConsultingClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alert", "Your Request has been submiteed. Expert will reach out to you soon", "OK");
        }
    }
}