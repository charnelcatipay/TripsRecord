using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripsRecord.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripsRecord
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoryPage : ContentPage
	{
		public HistoryPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            //conn.CreateTable<Post>();
            //var posts = conn.Table<Post>().ToList();
            //postListView.ItemsSource = posts;

            var posts = await App.MobileService.GetTable<Post>().Where(p => p.UserId == App.user.Id).ToListAsync();
            postListView.ItemsSource = posts;

        }


    }
}