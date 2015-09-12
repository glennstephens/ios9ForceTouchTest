using System;

using UIKit;

namespace TestApp2
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		bool hasForceTouch;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if (!UIDevice.CurrentDevice.CheckSystemVersion (9, 0))
			{
				hasForceTouch = false;
			} else {
				var traits = new UITraitCollection ();
				hasForceTouch = traits.ForceTouchCapability == UIForceTouchCapability.Available;
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void TouchesBegan (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);

			if (!hasForceTouch)
			{
				ClickForceLabel.Text = "Clicked on a pre-iOS9 or non-ForceTouch device";
				return;
			}

			var touch = (evt.AllTouches.AnyObject as UITouch);
			if (touch == null)
				return;
			
			var strengthOfTouch = touch.Force / touch.MaximumPossibleForce;
			ClickForceLabel.Text = string.Format ("You have a force of {0:P}", strengthOfTouch);
		}
	}
}

