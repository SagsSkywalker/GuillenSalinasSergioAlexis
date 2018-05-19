// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ExamenSegundoParcial
{
	[Register ("MyCell")]
	partial class MyCell
	{
		[Outlet]
		UIKit.UIImageView cellImage { get; set; }

		[Outlet]
		UIKit.UILabel cellTweet { get; set; }

		[Outlet]
		UIKit.UILabel cellUser { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cellImage != null) {
				cellImage.Dispose ();
				cellImage = null;
			}

			if (cellUser != null) {
				cellUser.Dispose ();
				cellUser = null;
			}

			if (cellTweet != null) {
				cellTweet.Dispose ();
				cellTweet = null;
			}
		}
	}
}
