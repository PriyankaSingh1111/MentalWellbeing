using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
namespace HealthWellBeing.Droid
{
    [Activity(Label = "HealthWellBeing", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static long reminderInterval = 60 * 1000;
        const string channelId = "default";
        const string channelName = "Default";
        const string channelDescription = "The default channel for notifications.";
        bool channelInitialized = false;
        NotificationManager manager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            // Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState); 
            LoadApplication(new App());
            CreateNotificationChannel();

            Intent alarmIntent = new Intent(this, typeof(AlarmReceiver));
            PendingIntent pending = PendingIntent.GetBroadcast(this, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);
            AlarmManager alarmManager = GetSystemService(AlarmService).JavaCast<AlarmManager>();
            alarmManager.SetRepeating(AlarmType.RtcWakeup, SystemClock.ElapsedRealtime(), reminderInterval, pending);
        }
        void CreateNotificationChannel()
        {
            //  manager = (NotificationManager)Application.Context.GetSystemService(Application.NotificationService)
            manager = (NotificationManager)Android.App.Application.Context.GetSystemService(Android.App.Application.NotificationService);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var channelNameJava = new Java.Lang.String(channelName);
                var channel = new NotificationChannel(channelId, channelNameJava, NotificationImportance.Default)
                {
                    Description = channelDescription
                };
                manager.CreateNotificationChannel(channel);
            }

            channelInitialized = true;
        }
    }
}