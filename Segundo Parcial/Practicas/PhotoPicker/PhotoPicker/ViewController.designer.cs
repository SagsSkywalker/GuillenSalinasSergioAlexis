// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PhotoPicker
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIImageView imgProfile { get; set; }

		[Outlet]
		UIKit.UILabel imgViewBottom { get; set; }

		[Outlet]
		UIKit.UILabel txtEditBottom { get; set; }

		[Outlet]
		UIKit.UILabel txtEditProfile { get; set; }

		[Outlet]
		UIKit.UIView upperView { get; set; }

		[Outlet]
		UIKit.UIView viewBottom { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgViewBottom != null) {
				imgViewBottom.Dispose ();
				imgViewBottom = null;
			}

			if (txtEditBottom != null) {
				txtEditBottom.Dispose ();
				txtEditBottom = null;
			}

			if (viewBottom != null) {
				viewBottom.Dispose ();
				viewBottom = null;
			}

			if (upperView != null) {
				upperView.Dispose ();
				upperView = null;
			}

			if (imgProfile != null) {
				imgProfile.Dispose ();
				imgProfile = null;
			}

			if (txtEditProfile != null) {
				txtEditProfile.Dispose ();
				txtEditProfile = null;
			}
		}
	}
}
