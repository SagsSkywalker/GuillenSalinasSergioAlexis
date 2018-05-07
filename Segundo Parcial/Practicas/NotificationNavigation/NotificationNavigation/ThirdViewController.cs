using System;
using Foundation;
using UIKit;

namespace NotificationNavigation
{
    public partial class ThirdViewController : UIViewController
    {
        //public const NSString ViewController + tiempo(did, will, Should) + accion + notification + key;
        public static readonly NSString ThirdViewControllerNotificationKey = new NSString("ThirdViewControllerNotificationKey");
        NSObject ThirdNotificationToken;

        public ThirdViewController(IntPtr handle) : base("ThirdViewController", null)
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
            ThirdNotificationToken = NSNotificationCenter.DefaultCenter.AddObserver(ThirdViewControllerNotificationKey, NotifyMe);
        }

        partial void btnUnregister(NSObject sender)
        {
            ThirdNotificationToken?.Dispose();
            ThirdNotificationToken = null;
        }

        partial void btnTestme(NSObject sender)
        {
            NSNotificationCenter.DefaultCenter.PostNotificationName(ThirdViewControllerNotificationKey.ToString(), null);
        }

        void NotifyMe(NSNotification notification)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = notification.Name,
                Message = "this is a simple alert"
            };
            alert.AddButton("OK");
            alert.Show();
            //Console.WriteLine("The ClockNotification message was posted");
        }
    }
}

