using System;

using Foundation;
using UIKit;

namespace ExamenSegundoParcial
{
    public partial class MyCell : UITableViewCell
    {
        public String Username
        {
            get => cellUser.Text;
            set => cellUser.Text = value;
        }
        public String Tweet
        {
            get => cellTweet.Text;
            set => cellTweet.Text = value;
        }
        public String UserImage
        {
            set{
                var url = new NSUrl(value);
                var data = NSData.FromUrl(url);
                cellImage.Image = new UIImage(data);
            }
        }

        public static readonly NSString Key = new NSString("MyCell");

        protected MyCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
