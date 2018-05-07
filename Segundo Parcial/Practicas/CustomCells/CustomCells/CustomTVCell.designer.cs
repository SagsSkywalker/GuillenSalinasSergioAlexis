// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomCells
{
	[Register ("CustomTVCell")]
	partial class CustomTVCell
	{
		[Outlet]
		UIKit.UIImageView imgView { get; set; }

		[Outlet]
		UIKit.UILabel myLabel { get; set; }

		[Action ("btnNeedHealing:")]
		partial void btnNeedHealing (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imgView != null) {
				imgView.Dispose ();
				imgView = null;
			}

			if (myLabel != null) {
				myLabel.Dispose ();
				myLabel = null;
			}
		}
	}
}
