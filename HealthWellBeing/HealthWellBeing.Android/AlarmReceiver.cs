using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using HealthWellBeing.Droid;
using AndroidApp = Android.App.Application;


namespace HealthWellBeing
{
    [BroadcastReceiver]
    public class AlarmReceiver : BroadcastReceiver
    {
        const string channelId = "default";
        const string channelName = "Default";
        const string channelDescription = "The default channel for notifications.";
        bool channelInitialized = false;
        NotificationManager manager;

        public override void OnReceive(Context context, Intent intent)
        {
            var title = "Mental Wellbeing";
            var message = "Hi,Please take a self assessment for today.";

            var nonIntent = new Intent(context, typeof(MainActivity));
            var contentIntent = PendingIntent.GetActivity(context, 0, nonIntent, PendingIntentFlags.CancelCurrent);



        //The activity opened when we click the notification is SecondActivity
        //Feel free to change it to you own activity
        //  var resultIntent = new Intent(context, typeof(SecondActivity));

        //   PendingIntent pending = PendingIntent.GetActivities(context, 0,
        //    new Intent[] { backIntent, resultIntent },
        //    PendingIntentFlags.OneShot);


        var builder =
                new NotificationCompat.Builder(context, channelId)
                    .SetContentTitle(title)
                    .SetContentText(message)
                    .SetAutoCancel(true)
                   .SetLargeIcon(BitmapFactory.DecodeResource(context.Resources, Resource.Drawable.happy))
                    .SetSmallIcon(Resource.Drawable.happy)
                    .SetDefaults((int)NotificationDefaults.Sound | (int)NotificationDefaults.Vibrate);
                

            builder.SetContentIntent(contentIntent);
            var notification = builder.Build();
            var managercontext = NotificationManager.FromContext(context);
            managercontext.Notify(0, notification);

        }
    }
}