using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Geofence.Plugin;
using Geofence.Plugin.Abstractions;

namespace MSU_Events
{
    public class loaddata
    {
        public static string[] title
        {
            get;
            set;
        }

    }
    class SplashPage : ContentPage
    {
        Image splashImage;
        Label title;


        public SplashPage()
        {

            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            title = new Label
            {
                TextColor = Color.Red
            };
            splashImage = new Image
            {
                Source = "logo.png",
                WidthRequest = 350,
                HeightRequest = 350
            };
            

            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            //var label = new Label { TextColor = Color.FromHex("#77d065"), FontSize = 20 };
            //label.Text = loaddata.title[0];
            sub.Children.Add(splashImage);
            sub.Children.Add(title);


            this.BackgroundColor = Color.FromHex("#002144");
            this.Content = sub;
        }


        protected override async void OnAppearing()
        {            

            base.OnAppearing();           

            await splashImage.ScaleTo(1, 1000); //Time-consuming processes such as initialization
            await splashImage.ScaleTo(0.9, 2000, Easing.Linear);
            await splashImage.ScaleTo(0, 1000, Easing.Linear);
            //Application.Current.MainPage = new MainPage();    //After loading  MainPage it gets Navigated to our new Page
            Application.Current.MainPage = new ListViewEvents();//new NavigationPage(new ListViewEvents());
            //MainPage.Navigation.PushAsync(new interactiveListViewXaml());
            //this.Navigation.PushAsync(new ListViewEvents(), true);

           
            
        }
    }
}
