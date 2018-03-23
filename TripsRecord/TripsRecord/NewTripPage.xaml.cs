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
	public partial class NewTripPage : ContentPage
	{
		public NewTripPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();

            int rows = conn.Insert(post);
            conn.Close();

            if (rows > 0)
                DisplayAlert("Success", "Experience Successfully Inserted", "Ok");
            else
                DisplayAlert("Failure", "Experience Failed to be Inserted", "Ok");
        }

    }
}