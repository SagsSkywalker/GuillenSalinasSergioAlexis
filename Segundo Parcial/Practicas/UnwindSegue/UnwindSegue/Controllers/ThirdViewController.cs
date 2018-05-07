using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UnwindSegue
{
    public partial class ThirdViewController : BaseViewController
    {
        public ThirdViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Message = $"I'm from {nameof(ThirdViewController)}";
        }

		partial void btnShowModal(NSObject sender)
		{
            var viewController = Storyboard.InstantiateViewController(nameof(MyModalViewController));
            NavigationController.PresentViewController(viewController, true, null);
		}

		partial void btnGoToFirst(NSObject sender)
		{
            PerformSegue("PrepareForUnwindToFirstViewController", null);
		}

        [Action("prepareForUnwind:")]
        void PrepareForUnwind(UIStoryboardSegue segue)
        {
            var sourceViewController = segue.SourceViewController as BaseViewController;
            Console.WriteLine(sourceViewController.Message);
        }

		public override bool CanPerformUnwind(Selector segueAction, UIViewController fromViewController, NSObject sender)
		{
            if (RespondsToSelector(segueAction))
            {
                return switchUnwind.On;
            }
            return false;
		}
	}
}

