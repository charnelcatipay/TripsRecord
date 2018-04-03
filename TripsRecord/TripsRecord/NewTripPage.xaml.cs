using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
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
	public partial class NewTripPage : ContentPage
	{
        NewTripVM viewModel;
        public NewTripPage ()
		{
			InitializeComponent ();

            viewModel = new NewTripVM();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //var locator = CrossGeolocator.Current;
            //var position = await locator.GetPositionAsync();

            //var venues = await Venue.GetVenues(position.Latitude, position.Longitude);

            //venueListView.ItemsSource = venues;

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need Permission", "We will have to access your location", "Ok");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    var locator = CrossGeolocator.Current;
                    var position = await locator.GetPositionAsync();

                    var venues = await Venue.GetVenues(position.Latitude, position.Longitude);
                    venueListView.ItemsSource = venues;
                }
                else
                {
                    await DisplayAlert("Need Permission", "We will have to access your location", "Ok");
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}