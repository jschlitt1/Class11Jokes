using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Class11Jokes
{
    public partial class App : Application
    {
        static JokeItemDatabase database;
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new JokeListPage());
            nav.BarBackgroundColor = Color.Red;
            nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static JokeItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new JokeItemDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
