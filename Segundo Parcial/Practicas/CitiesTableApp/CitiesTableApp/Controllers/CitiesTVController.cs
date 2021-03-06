// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace CitiesTableApp
{
    public partial class CitiesTVController : UITableViewController
    {
        #region Class Variables

        UIRefreshControl refreshControl;
        Dictionary<string, List<string>> cities;

        #endregion

        public CitiesTVController(IntPtr handle) : base(handle)
        {
        }

        #region Controller Life Cycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InitializeComponents();
        }
        #endregion

        #region TableView Data Source

        #endregion

        #region Internal Functionality

        void InitializeComponents()
        {
            Models.CitiesManager.SharedInstance.CitiesFetched += CitiesManager_CitiesFetched;
            Models.CitiesManager.SharedInstance.CitiesFetchedFailed += CitiesManager_CitiesFetchedFailed;
            cities = Models.CitiesManager.SharedInstance.GetDefaultCities();

            refreshControl = new UIRefreshControl();
            refreshControl.ValueChanged += RefreshControl_ValueChanged;
            TableView.RefreshControl = refreshControl;
        }

        #endregion

        #region User Interactions
        void RefreshControl_ValueChanged(object sender, EventArgs e)
        {
            //Descargar los datos de Internet
            Models.CitiesManager.SharedInstance.FetchCities();
            //refreshControl.EndRefreshing();
        }
        #endregion

        #region Cities Manager Events

        void CitiesManager_CitiesFetched(object sender, Models.CitiesManager.CitiesEventArgs e)
        {
            cities = e.Cities;
            InvokeOnMainThread(() => refreshControl.EndRefreshing());
            //Actualizar tabla
            myTable.DataSource = cities as IUITableViewDataSource;
        }

        void CitiesManager_CitiesFetchedFailed(object sender, EventArgs e)
        {
            Console.WriteLine($"Something failed...");
            InvokeOnMainThread(() => refreshControl.EndRefreshing());
        }

        #endregion

        //[Export("numberOfSectionsInTableView:")]
        //public override nint NumberOfSections(UITableView tableView)
        //{
        //    throw new System.NotImplementedException();
        //}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
            //return base.RowsInSection(tableView, section);
            return cities.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            //return base.GetCell(tableView, indexPath);
            //var cell = (myTable.DequeueReusableCell("@BasicTableViewCell", indexPath));
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "myCell");
            cell.TextLabel.Text = cities[indexPath.Row];
            return cell;
		}
	}
}
