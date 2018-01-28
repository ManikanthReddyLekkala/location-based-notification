using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Geofence.Plugin;
using Geofence.Plugin.Abstractions;

using Xamarin.Forms;

namespace MSU_Events
{
    public class ListViewEvents : ContentPage
    {

        public static ObservableCollection<string> items { get; set; }
        public ListViewEvents()
        {

            Image header = new Image
            {
                BackgroundColor = Color.FromHex("#002144"),
                Source = "MSU12.jpg",
                HorizontalOptions = LayoutOptions.Fill

            };

            //Label header = new Label
            //{
            //    BackgroundColor = Color.FromHex("#0b1e36"),
            //    HorizontalOptions = LayoutOptions.Fill,
            //    VerticalOptions =LayoutOptions.Fill,
            //    Text = "Murray State University",
            //    FontSize = 24,//Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    FontAttributes = FontAttributes.Bold,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    TextColor = Color.White

            //};
            items = new ObservableCollection<string>() { };

            ListView lstView = new ListView()
            {
                RowHeight = 50,
            };

            var temp = new DataTemplate(typeof(textViewCell));
            lstView.ItemTemplate = temp;
            lstView.IsPullToRefreshEnabled = true;
            lstView.Refreshing += OnRefresh;
            lstView.ItemSelected += OnSelection;
            lstView.ItemTapped += OnTap;
            lstView.ItemsSource = items;
            //Content = lstView;
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    lstView
                }
            };
        }
        protected override async void OnAppearing()
        {            
            items.Clear();
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync("http://csclab.murraystate.edu/mlekkala/api/?u=murray&k=racers&data=events_c");

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var articles = JsonConvert.DeserializeObject<RootObject>(responseBody);
                    

                    foreach (var item in articles.Data)
                    {
                        var reg = new GeofenceCircularRegion(item.venue_name, Convert.ToDouble(item.venue_lat), Convert.ToDouble(item.venue_lon), 100)
                        {

                            //To get notified if user stays in region for at least 5 minutes
                            NotifyOnStay = true,
                            StayedInThresholdDuration = TimeSpan.FromMinutes(1)

                        };
                        CrossGeofence.Current.StartMonitoring(reg);
                        items.Add(item.title.ToString());
                        
                    }
                    
                }

            }
        }
        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync("http://csclab.murraystate.edu/mlekkala/api/?u=murray&k=racers&data=events_c");

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var articles = JsonConvert.DeserializeObject<RootObject>(responseBody);

                    foreach (var item in articles.Data)
                    {
                        if (item.title == e.Item.ToString())
                        {
                            await DisplayAlert(item.title, "Location: " +item.venue_name +"\n Date: " + item.date_start, "Ok");

                        }

                    }


                }

            }
            
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //comment out if you want to keep selections
            ListView lst = (ListView)sender;
            lst.SelectedItem = null;
        }

        async void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            //put your refreshing logic here
            items.Clear();
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync("http://csclab.murraystate.edu/mlekkala/api/?u=murray&k=racers&data=events_c");

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var articles = JsonConvert.DeserializeObject<RootObject>(responseBody);

                    foreach (var item in articles.Data)
                    {
                        items.Add(item.title.ToString());
                        //title.Text += item.title;
                        //Debug.WriteLine("Hello " + item.title);
                    }
                }

            }
            //make sure to end the refresh state
            list.IsRefreshing = false;
        }
    }
    public class textViewCell : ViewCell
    {
        public textViewCell()
        {
            StackLayout layout = new StackLayout();
            layout.Padding = new Thickness(15, 0);
            Label label = new Label();

            label.SetBinding(Label.TextProperty, ".");
            layout.Children.Add(label);

            //var moreAction = new MenuItem { Text = "More" };
            //moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            //moreAction.Clicked += OnMore;

            //var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; // red background
            //deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            //deleteAction.Clicked += OnDelete;

            //this.ContextActions.Add(moreAction);
            //this.ContextActions.Add(deleteAction);
            View = layout;
        }

        void OnMore(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            //Do something here... e.g. Navigation.pushAsync(new specialPage(item.commandParameter));
            //page.DisplayAlert("More Context Action", item.CommandParameter + " more context action", 	"OK");
        }

        void OnDelete(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            ListViewEvents.items.Remove(item.CommandParameter.ToString());
        }
    }
}