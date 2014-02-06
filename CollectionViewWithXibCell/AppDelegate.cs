using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CollectionViewWithXibCell
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		CollectionViewController controller;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			controller = new CollectionViewController (new UICollectionViewFlowLayout () {
				SectionInset = new UIEdgeInsets (5, 5, 5, 5),
				MinimumInteritemSpacing = 5,
				MinimumLineSpacing = 5,
				ItemSize = new System.Drawing.SizeF (50, 50)
			});

			window.RootViewController = controller;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

