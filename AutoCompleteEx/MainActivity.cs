using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AutoCompleteEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Switch attentive;
 
        Switch presentative;
        Switch fast;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            AutoCompleteTextView autoC = FindViewById<AutoCompleteTextView>(Resource.Id.myauto);
            var adapter = new ArrayAdapter<string>(this,Resource.Layout.item_list,INTERNS);
            autoC.Adapter = adapter;

            attentive = FindViewById<Switch>(Resource.Id.attentive);
        
            presentative = FindViewById<Switch>(Resource.Id.presentative);
            fast = FindViewById<Switch>(Resource.Id.fast);

            attentive.CheckedChange += Attentive_CheckedChange;

            presentative.CheckedChange += Presentative_CheckedChange;
            fast.CheckedChange += Fast_CheckedChange;

        }

        private void Fast_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, "Your answer is " + (e.IsChecked ? "correct" : "incorrect"), ToastLength.Short).Show();
        }

        private void Presentative_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, "Your answer is " + (e.IsChecked ? "correct" : "incorrect"), ToastLength.Short).Show();
        }


        private void Attentive_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
           Toast.MakeText(this, "Your answer is " + (e.IsChecked ? "correct" : "incorrect"), ToastLength.Short).Show();
        }

        static string[] INTERNS = new string[]

        {  
            "Vedanshi","Aeris","Devansh","Hiral","Jay","Sagar","Mit","Priyank","Vruti"
        };
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}