﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TripsRecord
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var assembly = typeof(MainPage);


            iconImage.Source = ImageSource.FromResource("TripsRecord.Assets.Images.manphone.png", assembly);
		}

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty)
            { }
            else
            {
               Navigation.PushAsync(new HomePage());
            }
        }

        private void registerUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

    }
}
