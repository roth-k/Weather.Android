using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Weather.Services.Implementations;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;

namespace Weather.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
         }

        public async void test()
        {
            //var res = await new GetCurrentWeatherService().GetCurrentWeatherDefaultAsync("Tbilisi");
            var k = await new GetForecastService().GetForecatsDefault("Tbilisi");
        }

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            //throw new System.NotImplementedException();
            return false;
        }
    }
}