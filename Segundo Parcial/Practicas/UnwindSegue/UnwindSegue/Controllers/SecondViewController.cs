using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UnwindSegue
{
    public partial class SecondViewController : BaseViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Message = $"I'm from {nameof(SecondViewController)}";
        }

		partial void BtnGoToThirdViewController(NSObject sender)
		{
            var viewController = Storyboard.InstantiateViewController("ThirdViewController");
            NavigationController.PushViewController(viewController, true);
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

