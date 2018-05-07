using System;
using Foundation;
using UIKit;

namespace PassingData
{
    public partial class FirstViewController : UIViewController
    {
        #region Constructors
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        #endregion

        #region Controller Life Cycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
		#endregion

		#region Navigation

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            if(segue.Identifier != "DefaultSegue")
                return;
            (segue.DestinationViewController as SecondViewController).Chicken = txtFirst.Text;
            base.PrepareForSegue(segue, sender);
		}

		#endregion
	}
}
