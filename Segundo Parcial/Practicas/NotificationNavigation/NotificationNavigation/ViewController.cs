using System;
using Foundation;
using UIKit;

namespace NotificationNavigation
{
    public partial class ViewController : UIViewController
    {
        //public const NSString ViewController + tiempo(did, will, Should) + accion + notification + key;
        public static readonly NSString ViewControllerNotificationKey = new NSString("ViewControllerNotificationKey");
        NSObject notificationToken;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Console.WriteLine("Se cargo la app");
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
            notificationToken = NSNotificationCenter.DefaultCenter.AddObserver(ViewControllerNotificationKey, NotifyMe);
		}

		partial void btnUnregister(NSObject sender)
		{
            notificationToken?.Dispose();
            notificationToken = null;
		}

		partial void btnTestme(NSObject sender)
		{
            NSNotificationCenter.DefaultCenter.PostNotificationName(ViewControllerNotificationKey.ToString(), null);
		}

		void NotifyMe(NSNotification notification){
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
