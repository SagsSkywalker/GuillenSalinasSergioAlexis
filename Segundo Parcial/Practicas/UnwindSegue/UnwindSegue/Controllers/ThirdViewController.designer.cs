// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UnwindSegue
{
	[Register ("ThirdViewController")]
	partial class ThirdViewController
	{
		[Outlet]
		UIKit.UISwitch switchUnwind { get; set; }

		[Action ("btnDoUnwind:")]
		partial void btnDoUnwind (Foundation.NSObject sender);

		[Action ("btnGoToFirst:")]
		partial void btnGoToFirst (Foundation.NSObject sender);

		[Action ("btnShowModal:")]
		partial void btnShowModal (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (switchUnwind != null) {
				switchUnwind.Dispose ();
				switchUnwind = null;
			}
		}
	}
}
