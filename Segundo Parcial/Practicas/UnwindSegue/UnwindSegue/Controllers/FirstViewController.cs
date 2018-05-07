using System;
using Foundation;
using UIKit;

namespace UnwindSegue
{
    public partial class FirstViewController : BaseViewController
    {
        #region Constructors
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }
        #endregion

        #region Controller Life Cycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
        #endregion

        #region Unwind Segues

        [Action("prepareForUnwindToFirstViewController:")]
        void PrepareForUnwindToFirstViewController(UIStoryboardSegue segue){
            var sourceViewController = segue.SourceViewController as BaseViewController;
            Console.WriteLine(sourceViewController.Message);
        }

        [Action("prepareForUnwind:")]
        void PrepareForUnwinds(UIStoryboardSegue segue)
        {
            var sourceViewController = segue.SourceViewController as BaseViewController;
            Console.WriteLine(sourceViewController.Message);
        }

        #endregion
    }
}

