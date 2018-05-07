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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        UIKit.UISwitch switchUnwind { get; set; }

        [Action ("btnDoUnwind:")]
        partial void btnDoUnwind (Foundation.NSObject sender);

        [Action ("BtnGoToThirdViewController:")]
        partial void BtnGoToThirdViewController (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (switchUnwind != null) {
                switchUnwind.Dispose ();
                switchUnwind = null;
            }
        }
    }
}
