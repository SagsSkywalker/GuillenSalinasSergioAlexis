using System;

using UIKit;

namespace PassingData
{
    public partial class SecondViewController : UIViewController
    {
        #region Properties
        public string Chicken { get; set; }
        #endregion

        #region Constructors
        //Constructor a ser usado por el MainStoryboard
        public SecondViewController(IntPtr handle) : base(handle)
        {
            
        }
        #endregion

        #region Controller Life Cycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            txtSecond.Text = Chicken;
        }
        #endregion
    }
}

