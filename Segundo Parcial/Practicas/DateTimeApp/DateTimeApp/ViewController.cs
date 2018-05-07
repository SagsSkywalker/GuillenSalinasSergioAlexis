using System;
using Foundation;
using UIKit;

namespace DateTimeApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        #region User Interactions
        partial void btnDateTime(Foundation.NSObject sender)
        {
            var currentTime = DateTime.Now;
            txtDate.Text = currentTime.ToShortDateString();
            txtTime.Text = currentTime.ToShortTimeString();
        }

        partial void btnNSDate(Foundation.NSObject sender)
        {
            NSDate date = new NSDate();
            NSLocale cultureInfo = new NSLocale("es");
            NSDateFormatter newdate = new NSDateFormatter()
            {
                DateFormat = "dd 'de' MMMM 'de' yyyy",
                Locale = cultureInfo
            };
            NSDateFormatter time = new NSDateFormatter()
            {
                DateFormat = "hh:MM:ss aa",
                Locale = cultureInfo
            };
            txtDate.Text = newdate.ToString(date);
            txtTime.Text = time.ToString(date);
            #endregion
        }
    }
}
