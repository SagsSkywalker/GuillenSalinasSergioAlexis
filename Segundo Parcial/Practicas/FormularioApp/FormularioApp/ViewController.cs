using System;
using System.Collections.Generic;
using UIKit;
using Foundation;

namespace FormularioApp
{
    public partial class ViewController : UIViewController
    {
        #region Class Variables
        List<string> genderList = new List<string>
        {
            "Male", "Female", "Other"
        };
        #endregion
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var GenderModel = new GenderViewModel(genderList);
            GenderModel.genderChange += (sender, e) =>
            {
                return;
            };
            pckGender.Model = GenderModel;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
