// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FormularioApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIPickerView pckAge { get; set; }

		[Outlet]
		UIKit.UIPickerView pckGender { get; set; }

		[Outlet]
		UIKit.UITextField txtName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (pckAge != null) {
				pckAge.Dispose ();
				pckAge = null;
			}

			if (pckGender != null) {
				pckGender.Dispose ();
				pckGender = null;
			}
		}
	}
}
