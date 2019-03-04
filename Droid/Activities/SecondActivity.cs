using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace test1.Droid
{
    [Activity(Label = "Second Activity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Get the count value passed to us from MainActivity:
            var count = Intent.Extras.GetInt(MainActivity.COUNT_KEY, -1);

            // No count was passed? Then just return.
            //if (count <= 0)
            //{
            //    return;
            //}

            // Display the count sent from the first activity:
            SetContentView(Resource.Layout.activity_add_item);
            //var txtView = FindViewById<TextView>(Resource.Id.textView1);
            //txtView.Text = $"You clicked the button in the previous activity.";
        }
    }
}