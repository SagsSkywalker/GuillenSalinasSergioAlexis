using System;

using UIKit;

namespace UnwindSegue
{
    public partial class BaseViewController : UIViewController
    {
        #region Properties
        public string Message { get; set;}
        #endregion
        #region Constructors
        public BaseViewController(IntPtr handle) : base("BaseViewController", null)
        {
        }
        #endregion
    }
}

