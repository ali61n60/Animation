using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
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


        private int _numberOfRotation = 0;
        private void fadeBart(object sender, System.EventArgs e)
        {
            _numberOfRotation++;
            _imageViewBart.Animate().Rotation(45f*_numberOfRotation).SetDuration(500);
        }
    }
}

