using System;
using Foundation;
using UIKit;

namespace NotificationNavigation
{
    public partial class SecondViewController : UIViewController
    {
        public static readonly NSString SecondViewControllerNotificationKey = new NSString("SecondViewControllerNotificationKey");
        NSObject SecondNotificationToken;

        public SecondViewController(IntPtr handle) : base("SecondViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //User Interactions
        //Button Register NSNotification
        partial void btnRegister(NSObject sender)
        {
            SecondNotificationToken = NSNotificationCenter.DefaultCenter.AddObserver(SecondViewControllerNotificationKey, NotifyMe);
        }

        partial void btnUnregister(NSObject sender)
        {
            SecondNotificationToken?.Dispose();
            SecondNotificationToken = null;
        }

        partial void btnTestme(NSObject sender)
        {
            NSNotificationCenter.DefaultCenter.PostNotificationName(SecondViewControllerNotificationKey.ToString(), null);
        }

        void NotifyMe(NSNotification notification)
        {
            if (SecondNotificationToken != null)
            {
                UIAlertView alert = new UIAlertView()
                {
                    Title = notification.Name,
                    Message = "this is a simple alert"
                };
                alert.AddButton("OK");
                alert.Show();
            }
            //Console.WriteLine("The ClockNotification message was posted");
        }
    }
}

