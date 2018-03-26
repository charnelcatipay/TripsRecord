using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripsRecord.Model;
using TripsRecord.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripsRecord
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoryPage : ContentPage
	{
        HistoryVM viewModel;
        public HistoryPage ()
		{
			InitializeComponent ();

            viewModel = new HistoryVM();
            BindingContext = viewModel;
        }

        protected override  void OnAppearing()
        {
            base.OnAppearing();

            viewModel.UpdatePosts();

        }


    }
}