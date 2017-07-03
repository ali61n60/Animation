using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Views.Animations;
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
            AnimationSet animationSet=new AnimationSet(false);
            long duration =300;
            animationSet.AddAnimation(createAnimation(1f,0.5f,1f,0.5f,duration,0));
            animationSet.AddAnimation(createAnimation(1f,4f, 1f, 4f,duration,1*duration));
            animationSet.AddAnimation(createAnimation(1f, 0.5f, 1f, 0.5f,duration, 2*duration));

            animationSet.FillAfter = true;

            // scale(0.5f,1000,0);
            //scale(2f,1000,1000);
            //scale(1f,1000,2000);

            _imageViewBart.StartAnimation(animationSet);
        }

        private ScaleAnimation createAnimation(float x0,float x1,float y0,float y1,long duration,long startOffset)
        {
            ScaleAnimation scaleAnimation = new ScaleAnimation(x0,x1,y0,y1);
            scaleAnimation.Duration = duration;
            scaleAnimation.StartOffset = startOffset;
            scaleAnimation.FillAfter = true;
            return scaleAnimation;
        }


    }
}

