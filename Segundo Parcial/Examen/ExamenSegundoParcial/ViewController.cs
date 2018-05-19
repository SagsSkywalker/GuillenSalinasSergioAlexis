using System;
using Tweetinvi;
using Foundation;
using System.Linq;
using UIKit;

namespace ExamenSegundoParcial
{
    public partial class ViewController : UIViewController
    {
        UISearchBar searchBar { get; set; }
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Auth.SetUserCredentials(TwitterCredentials.ConsumerKey,
                                    TwitterCredentials.ConsumerSecret,
                                    TwitterCredentials.AccessToken,
                                    TwitterCredentials.AccessTokenSecret);
            searchBar = new UISearchBar()
            {
                Placeholder = "Busca los tweets",
                ShowsScopeBar = false,
                ScopeButtonTitles = new string[] {"uwu", "owo", "ewe"}
            };

            var schController = new UISearchController();
            myTable.TableHeaderView = schController.SearchBar;

            searchBar.SearchBarStyle = UISearchBarStyle.Prominent;

            myTable.TableHeaderView = searchBar;

            searchBar.SearchButtonClicked += (sender, args) =>
            {
                ReloadMyTable(searchBar.Text);
                searchBar.PerformSelector(new ObjCRuntime.Selector("resignFirstResponder"), this, 0.5);
            };
        }

        void ReloadMyTable(string query){
            if (string.IsNullOrWhiteSpace(query))
            {
                return;
            }
            var tweets = Search.SearchTweets(query).ToArray();
            var tablesource = new MyTableViewSource(tweets);

            myTable.Source = tablesource;
            myTable.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
