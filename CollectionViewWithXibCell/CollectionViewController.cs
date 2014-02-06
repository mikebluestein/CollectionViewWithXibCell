using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CollectionViewWithXibCell
{
	public class CollectionViewController : UICollectionViewController
	{
		static readonly NSString cellId = new NSString ("CVCell");

		public CollectionViewController (UICollectionViewLayout layout) : base (layout)
		{
			CollectionView.ContentSize = UIScreen.MainScreen.Bounds.Size;
		}
            
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CollectionView.BackgroundColor = UIColor.White;

			CollectionView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);

			CollectionView.RegisterNibForCell (UINib.FromName ("CVCell", NSBundle.MainBundle), cellId);
		}
          
		public override int GetItemsCount (UICollectionView collectionView, int section)
		{
			return 100;
		}
            
		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (CVCell)collectionView.DequeueReusableCell (cellId, indexPath);

			cell.Text = indexPath.Row.ToString ();

			return cell;
		}
	}          
}

