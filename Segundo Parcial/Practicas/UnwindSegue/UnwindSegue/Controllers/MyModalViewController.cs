using System;
using Foundation;
using UIKit;

namespace UnwindSegue
{
    public partial class MyModalViewController : BaseViewController
    {
        public MyModalViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Message = $"I'm from {nameof(MyModalViewController)}";
        }

        [Action("prepareForUnwind:")]
        void PrepareForUnwind(UIStoryboardSegue segue)
        {
            var sourceViewController = segue.SourceViewController as BaseViewController;
            Console.WriteLine(sourceViewController.Message);
        }

		partial void doUnwind(NSObject sender)
		{
            PerformSegue("doUnwind", this);
		}
	}
}

