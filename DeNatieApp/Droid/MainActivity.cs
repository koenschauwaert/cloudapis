
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace XamarinAllianceApp.Droid
{
    [Activity (Label = "De Natie App",
		Icon = "@drawable/denatielogo",
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
		Theme = "@android:style/Theme.Material.Dark")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Initialize Xamarin Forms
			global::Xamarin.Forms.Forms.Init (this, bundle);

			// Load the main application
			LoadApplication (new App ());
		}
	}
}

