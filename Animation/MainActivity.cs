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
            _imageViewBart.Click += fade;
        }

        private void fade(object sender, System.EventArgs e)
        {
            _imageViewBart.Animate().Alpha(0f).SetDuration(2000).WithEndAction(new Runnable(() =>
            {
                _imageViewBart.SetImageDrawable(Resources.GetDrawable(Resource.Drawable.homer));
                _imageViewBart.Animate().Alpha(1.0f).SetDuration(2000);
            }));




        }
    }
}

