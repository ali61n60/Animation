using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace Animation
{
    [Activity(Label = "Animation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ImageView _imageViewBart;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            initFields();
            
        }

        private void initFields()
        {
            _imageViewBart = FindViewById<ImageView>(Resource.Id.imageViewBart);
            _imageViewBart.Click += fadeBart;

          
        }

      

        private void fadeBart(object sender, System.EventArgs e)
        {
            _imageViewBart.Animate().XBy(-100f).SetDuration(2000);
            _imageViewBart.Animate().YBy(100f).SetDuration(2000);
        }
    }
}

