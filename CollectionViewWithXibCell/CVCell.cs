using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CollectionViewWithXibCell
{
    public partial class CVCell : UICollectionViewCell
    {
		public string Text {
			set{
				Label.Text = value;
			}
		}

        public CVCell (IntPtr handle) : base (handle)
        {
        }
    }
}

