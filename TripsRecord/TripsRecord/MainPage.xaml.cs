using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripsRecord.Model;
using TripsRecord.ViewModel.Commands;
using Xamarin.Forms;

namespace TripsRecord
{
	public partial class MainPage : ContentPage
	{
        MainVM viewModel;
		public MainPage()
		{
			InitializeComponent();

            var assembly = typeof(MainPage);

            viewModel = new MainVM();
            BindingContext = viewModel;

            iconImage.Source = ImageSource.FromResource("TripsRecord.Assets.Images.manphone.png", assembly);
		}

    }
}
