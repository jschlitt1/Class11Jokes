﻿using System;
using Xamarin.Forms;

namespace Class11Jokes
{
    public partial class JokeListPage : ContentPage
    {
        public JokeListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JokeItemPage
            {
                BindingContext = new JokeItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new JokeItemPage
                {
                    BindingContext = e.SelectedItem as JokeItem
                });
            }
        }
    }
}
