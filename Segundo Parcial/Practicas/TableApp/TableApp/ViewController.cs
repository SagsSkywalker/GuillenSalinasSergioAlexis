using System;
using Foundation;
using UIKit;

namespace TableApp
{
    public partial class ViewController : UIViewController, IUITableViewDelegate, IUITableViewDataSource
    {
        #region Constructors
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        #endregion

        #region Controller Life Cycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            tableView.DataSource = this;
            tableView.Delegate = this;
        }
        #endregion

        #region UITableView Data Source
        [Export("numberOfSectionsInTableView:")]
        public nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("BasicTableViewCell", indexPath);
            cell.TextLabel.Text = "Impressive.";
            return cell;
        }
        #endregion

        #region UITableView Delegate

        #endregion
    }
}
