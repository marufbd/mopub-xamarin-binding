using Android.App;
using Android.OS;
using Android.Widget;
using com.mopub.mobileads;

namespace SampleApp
{
    [Activity(Label = "SampleApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int _count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", _count++); };


            //setup ads
            var moPubViewBanner = FindViewById<MoPubView>(Resource.Id.adview_banner);
            moPubViewBanner.Testing = true;
            moPubViewBanner.AdUnitId = Resources.GetString(Resource.String.mopub_ad_id_banner);
            moPubViewBanner.LoadAd();
        }
    }
}

