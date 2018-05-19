using System;
using Foundation;
using UIKit;
using Tweetinvi.Models;
using Foundation;

namespace ExamenSegundoParcial
{
    public partial class MyTableViewSource : UITableViewSource
    {
        const string Identifier = "MyCell";
        private readonly ITweet[] Ctweets;

        public MyTableViewSource(ITweet[] tweets)
        {
            Ctweets = tweets;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(MyCell.Key, indexPath) as MyCell;

            //String username = Ctweets[indexPath.Row].CreatedBy.Name;
            //String tweetcont = Ctweets[indexPath.Row].Text;
            //String imageurl = Ctweets[indexPath.Row].CreatedBy.ProfileImageUrlHttps;

            cell.Username = Ctweets[indexPath.Row].CreatedBy.Name;
            cell.Tweet = Ctweets[indexPath.Row].Text;
            cell.UserImage = Ctweets[indexPath.Row].CreatedBy.ProfileImageUrlHttps;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Ctweets.Length;
        }
    }
}

