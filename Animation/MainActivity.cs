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
        private ImageView _imageViewHomer;
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

            _imageViewHomer = FindViewById<ImageView>(Resource.Id.imageViewHomer);
            _imageViewHomer.Click += fadeHomer;
        }

        private void fadeHomer(object sender, System.EventArgs e)
        {

            _imageViewBart.Animate().Alpha(1.0f).SetDuration(2000);
            _imageViewHomer.Animate().Alpha(0f).SetDuration(2000);
            _imageViewBart.TranslationZ = 10;
            _imageViewHomer.TranslationZ = 0;
        }

        private void fadeBart(object sender, System.EventArgs e)
        {
            _imageViewBart.Animate().Alpha(0f).SetDuration(2000);
            _imageViewHomer.Animate().Alpha(1.0f).SetDuration(2000);
            _imageViewBart.TranslationZ = 0;
            _imageViewHomer.TranslationZ = 10;
        }
    }
}

