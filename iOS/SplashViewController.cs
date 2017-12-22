using System;
using Airbnb.Lottie;
using UIKit;

namespace lottietest.iOS
{
    public partial class SplashViewController : UIViewController
    {
        public SplashViewController() : base("SplashViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var animationView = LOTAnimationView.AnimationNamed("loading_gears");
            this.View.AddSubview(animationView);
            animationView.PlayWithCompletion((animationFinished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching(UIApplication.SharedApplication,
                                                                           new Foundation.NSDictionary());
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}

