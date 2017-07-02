using Android.App;
using Android.Widget;
using Android.OS;

namespace Animation
{
    [Activity(Label = "Animation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            initFields();
            initAnimation();
        }

        private void initAnimation()
        {
            throw new System.NotImplementedException();
        }

        private void initFields()
        {
            throw new System.NotImplementedException();
        }
    }
}

